#![no_std]

use gstd::msg;
use sails_rtl::gstd::services::Service;
use this_that_svc_app::MyService;

#[gstd::async_main]
async fn main() {
    let input_bytes = msg::load_bytes().expect("Failed to read input");
    let output_bytes = MyService::new()
        .expose(&[1, 2, 3])
        .handle(&input_bytes)
        .await;
    msg::reply_bytes(output_bytes, 0).expect("Failed to send output");
}
