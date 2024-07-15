use crate::{
    ctor_generators::*, events_generator::*, io_generators::*, service_generators::*,
    type_generators::*,
};
use convert_case::{Case, Casing};
use genco::prelude::*;
use rust::Tokens;
use sails_idl_parser::{ast::visitor::Visitor, ast::*};

pub(crate) struct RootGenerator<'a> {
    tokens: Tokens,
    traits_tokens: Tokens,
    anonymous_service_name: &'a str,
}

impl<'a> RootGenerator<'a> {
    pub(crate) fn new(anonymous_service_name: &'a str) -> Self {
        let tokens = quote! {
            #[allow(unused_imports)]
            use sails::{prelude::*, String, calls::{Activation, Call, Query, Remoting, RemotingAction}};
            #[allow(unused_imports)]
            use sails::collections::BTreeMap;
            use core::marker::PhantomData;
        };

        Self {
            anonymous_service_name,
            tokens,
            traits_tokens: Tokens::new(),
        }
    }

    pub(crate) fn finalize(self) -> String {
        let result: Tokens = quote! {
            $(self.tokens)

            pub mod traits {
                use super::*;
                $(self.traits_tokens)
            }
        };

        let mut result = result.to_file_string().unwrap();

        result.insert_str(0, "// Code generated by sails-client-gen. DO NOT EDIT.\n");

        result
    }
}

impl<'a, 'ast> Visitor<'ast> for RootGenerator<'a> {
    fn visit_ctor(&mut self, ctor: &'ast Ctor) {
        let mut ctor_gen = CtorTraitGenerator::new(self.anonymous_service_name.to_owned());
        ctor_gen.visit_ctor(ctor);

        self.traits_tokens.extend(ctor_gen.finalize());

        let mut ctor_gen = CtorFactoryGenerator::new(self.anonymous_service_name.to_owned());
        ctor_gen.visit_ctor(ctor);
        self.tokens.extend(ctor_gen.finalize());
    }

    fn visit_service(&mut self, service: &'ast Service) {
        let service_name = if service.name().is_empty() {
            self.anonymous_service_name
        } else {
            service.name()
        };
        let service_name_snake = service_name.to_case(Case::Snake);

        let mut service_gen = ServiceTraitGenerator::new(service_name.to_owned());
        service_gen.visit_service(service);
        self.traits_tokens.extend(service_gen.finalize());

        let path = service.name();

        let mut client_gen = ServiceClientGenerator::new(service_name.to_owned());
        client_gen.visit_service(service);
        self.tokens.extend(client_gen.finalize());

        let mut service_tokens = Tokens::new();

        let mut io_mod_gen = IoModuleGenerator::new(path.to_owned());
        io_mod_gen.visit_service(service);
        service_tokens.extend(io_mod_gen.finalize());

        if !service.events().is_empty() {
            let mut events_mod_gen =
                EventsModuleGenerator::new(service_name.to_owned(), path.to_owned());
            events_mod_gen.visit_service(service);
            service_tokens.extend(events_mod_gen.finalize());
        }

        quote_in! { self.tokens =>
            pub mod $(service_name_snake) {
                use super::*;
                $(service_tokens)
            }
        }
    }

    fn visit_type(&mut self, t: &'ast Type) {
        let mut type_gen = TopLevelTypeGenerator::new(t.name());
        type_gen.visit_type(t);
        self.tokens.extend(type_gen.finalize());
    }
}
