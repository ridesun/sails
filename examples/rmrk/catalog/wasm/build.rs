use rmrk_catalog_app::Program;
use sails_idl_gen::program;
use std::{env, path::PathBuf};

fn main() {
    gwasm_builder::build();

    program::generate_idl_to_file::<Program>(
        PathBuf::from(env::var("CARGO_MANIFEST_DIR").unwrap()).join("rmrk-catalog.idl"),
    )
    .unwrap();
}
