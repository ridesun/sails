#![no_std]

use sails_rs::gstd::{calls::GStdRemoting, gprogram, groute, GStdExecContext};
use services::ResourceStorage;

mod catalogs;
// Exposed publicly because of tests which use generated data
// while there is no generated client
pub mod services;

type RmrkCatalog = catalogs::RmrkCatalog<GStdRemoting>;

#[derive(Default)]
pub struct Program;

#[gprogram]
impl Program {
    // Initialize program and seed hosted services
    pub fn new() -> Self {
        let exec_context = GStdExecContext::default();
        ResourceStorage::<_, RmrkCatalog>::seed(exec_context);
        Self
    }

    // Expose hosted service
    #[groute("RmrkResource")]
    pub fn resource_storage(&self) -> ResourceStorage<GStdExecContext, RmrkCatalog> {
        ResourceStorage::new(GStdExecContext::default(), RmrkCatalog::new(GStdRemoting))
    }

    // Will be generated by the `ginject_defaults` macro from the `new` method
    fn __new(exec_context: GStdExecContext) -> Self {
        ResourceStorage::<_, RmrkCatalog>::seed(exec_context);
        Self
    }

    // Will be generated by the `ginject_defaults` macro from the `resource_storage` method
    fn ___resource_storage(
        &self,
        exec_context: GStdExecContext,
        remoting: GStdRemoting,
    ) -> ResourceStorage<GStdExecContext, RmrkCatalog> {
        ResourceStorage::new(exec_context, RmrkCatalog::new(remoting))
    }
}
