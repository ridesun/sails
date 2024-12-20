//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Gear.Api.Generated.Model.pallet_gear_voucher.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> issue
        /// See [`Pallet::issue`].
        /// </summary>
        issue = 0,
        
        /// <summary>
        /// >> call
        /// See [`Pallet::call`].
        /// </summary>
        call = 1,
        
        /// <summary>
        /// >> revoke
        /// See [`Pallet::revoke`].
        /// </summary>
        revoke = 2,
        
        /// <summary>
        /// >> update
        /// See [`Pallet::update`].
        /// </summary>
        update = 3,
        
        /// <summary>
        /// >> decline
        /// See [`Pallet::decline`].
        /// </summary>
        decline = 4,
    }
    
    /// <summary>
    /// >> 267 - Variant[pallet_gear_voucher.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Gear.Api.Generated.Types.Base.BTreeSetT1>, Substrate.NetApi.Model.Types.Primitive.Bool, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.issue);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.pallet_gear_voucher.@internal.VoucherId, Substrate.Gear.Api.Generated.Model.pallet_gear_voucher.@internal.EnumPrepaidCall>>(Call.call);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.Gear.Api.Generated.Model.pallet_gear_voucher.@internal.VoucherId>>(Call.revoke);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.Gear.Api.Generated.Model.pallet_gear_voucher.@internal.VoucherId, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Gear.Api.Generated.Types.Base.BTreeSetT1>>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.Bool>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>>(Call.update);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_gear_voucher.@internal.VoucherId>(Call.decline);
        }
    }
}
