#![no_std]

use catalogs::Client as CatalogClient;
use sails_macros::{gprogram, groute};
use sails_rtl::gstd::{events::GStdEventTrigger, GStdExecContext};
use sails_sender::GStdSender;
use services::{ResourceStorage, ResourceStorageEvent};

mod catalogs;
// Exposed publicly because of tests which use generated data
// while there is no generated client
pub mod services;

type ResourceStorageEventTrigger = GStdEventTrigger<ResourceStorageEvent>;

#[derive(Default)]
pub struct Program;

#[gprogram]
impl Program {
    // Initialize program and seed hosted services
    pub fn new() -> Self {
        let exec_context = GStdExecContext::default();
        ResourceStorage::<_, CatalogClient, ResourceStorageEventTrigger>::seed(exec_context);
        Self
    }

    // Expose hosted service
    #[groute("")]
    pub fn resource_storage(
        &self,
    ) -> ResourceStorage<GStdExecContext, CatalogClient, ResourceStorageEventTrigger> {
        ResourceStorage::new(
            GStdExecContext::default(),
            CatalogClient::new(GStdSender),
            GStdEventTrigger::new(),
        )
    }

    // Will be generated by the `ginject_defaults` macro from the `new` method
    fn __new(exec_context: GStdExecContext) -> Self {
        ResourceStorage::<_, CatalogClient, ResourceStorageEventTrigger>::seed(exec_context);
        Self
    }

    // Will be generated by the `ginject_defaults` macro from the `resource_storage` method
    fn __resource_storage(
        &self,
        exec_context: GStdExecContext,
        sender: GStdSender,
        event_trigger: ResourceStorageEventTrigger,
    ) -> ResourceStorage<GStdExecContext, CatalogClient, ResourceStorageEventTrigger> {
        ResourceStorage::new(exec_context, CatalogClient::new(sender), event_trigger)
    }
}
