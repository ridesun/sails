#![no_std]

use catalogs::Client as CatalogClient;
use sails_macros::gprogram;
use sails_rtl_gstd::GStdExecContext;
use sails_sender::GStdSender;
use services::ResourceStorage;

mod catalogs;
// Exposed publicly because of service metadata for IDL
// Will be superseded by program metadata, thus pub won't be needed
pub mod services;

#[derive(Default)]
pub struct Program;

#[gprogram]
impl Program {
    // Initialize program and seed hosted services
    pub fn new() -> Self {
        let exec_context = GStdExecContext::default();
        ResourceStorage::<_, CatalogClient>::seed(exec_context);
        Self
    }

    // Expose hosted service
    pub fn resource_storage(&self) -> ResourceStorage<GStdExecContext, CatalogClient> {
        let exec_context = GStdExecContext::default();
        ResourceStorage::new(exec_context, CatalogClient::new(GStdSender))
    }

    // Will be generated by the `ginject_defaults` macro from the `new` method
    fn __new(exec_context: GStdExecContext) -> Self {
        ResourceStorage::<_, CatalogClient>::seed(exec_context);
        Self
    }

    // Will be generated by the `ginject_defaults` macro from the `resource_storage` method
    fn __resource_storage(
        &self,
        exec_context: GStdExecContext,
        sender: GStdSender,
    ) -> ResourceStorage<GStdExecContext, CatalogClient> {
        ResourceStorage::new(exec_context, CatalogClient::new(sender))
    }
}

// The below code will be generated by the `gprogram` macro
#[cfg(target_arch = "wasm32")]
pub mod wasm_main {
    use super::wasm::PROGRAM;
    use super::*;
    use sails_rtl_gstd::{gstd, gstd::msg};

    #[gstd::async_main]
    async fn main() {
        let input_bytes = msg::load_bytes().expect("Failed to read input");
        let mut resource_storage = unsafe { PROGRAM.as_ref().unwrap() }.resource_storage();
        let output_bytes = resource_storage.handle(&input_bytes).await;
        msg::reply_bytes(output_bytes, 0).expect("Failed to send output");
    }
}
