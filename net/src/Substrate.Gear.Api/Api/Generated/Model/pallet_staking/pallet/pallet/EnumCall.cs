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


namespace Substrate.Gear.Api.Generated.Model.pallet_staking.pallet.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> bond
        /// See [`Pallet::bond`].
        /// </summary>
        bond = 0,
        
        /// <summary>
        /// >> bond_extra
        /// See [`Pallet::bond_extra`].
        /// </summary>
        bond_extra = 1,
        
        /// <summary>
        /// >> unbond
        /// See [`Pallet::unbond`].
        /// </summary>
        unbond = 2,
        
        /// <summary>
        /// >> withdraw_unbonded
        /// See [`Pallet::withdraw_unbonded`].
        /// </summary>
        withdraw_unbonded = 3,
        
        /// <summary>
        /// >> validate
        /// See [`Pallet::validate`].
        /// </summary>
        validate = 4,
        
        /// <summary>
        /// >> nominate
        /// See [`Pallet::nominate`].
        /// </summary>
        nominate = 5,
        
        /// <summary>
        /// >> chill
        /// See [`Pallet::chill`].
        /// </summary>
        chill = 6,
        
        /// <summary>
        /// >> set_payee
        /// See [`Pallet::set_payee`].
        /// </summary>
        set_payee = 7,
        
        /// <summary>
        /// >> set_controller
        /// See [`Pallet::set_controller`].
        /// </summary>
        set_controller = 8,
        
        /// <summary>
        /// >> set_validator_count
        /// See [`Pallet::set_validator_count`].
        /// </summary>
        set_validator_count = 9,
        
        /// <summary>
        /// >> increase_validator_count
        /// See [`Pallet::increase_validator_count`].
        /// </summary>
        increase_validator_count = 10,
        
        /// <summary>
        /// >> scale_validator_count
        /// See [`Pallet::scale_validator_count`].
        /// </summary>
        scale_validator_count = 11,
        
        /// <summary>
        /// >> force_no_eras
        /// See [`Pallet::force_no_eras`].
        /// </summary>
        force_no_eras = 12,
        
        /// <summary>
        /// >> force_new_era
        /// See [`Pallet::force_new_era`].
        /// </summary>
        force_new_era = 13,
        
        /// <summary>
        /// >> set_invulnerables
        /// See [`Pallet::set_invulnerables`].
        /// </summary>
        set_invulnerables = 14,
        
        /// <summary>
        /// >> force_unstake
        /// See [`Pallet::force_unstake`].
        /// </summary>
        force_unstake = 15,
        
        /// <summary>
        /// >> force_new_era_always
        /// See [`Pallet::force_new_era_always`].
        /// </summary>
        force_new_era_always = 16,
        
        /// <summary>
        /// >> cancel_deferred_slash
        /// See [`Pallet::cancel_deferred_slash`].
        /// </summary>
        cancel_deferred_slash = 17,
        
        /// <summary>
        /// >> payout_stakers
        /// See [`Pallet::payout_stakers`].
        /// </summary>
        payout_stakers = 18,
        
        /// <summary>
        /// >> rebond
        /// See [`Pallet::rebond`].
        /// </summary>
        rebond = 19,
        
        /// <summary>
        /// >> reap_stash
        /// See [`Pallet::reap_stash`].
        /// </summary>
        reap_stash = 20,
        
        /// <summary>
        /// >> kick
        /// See [`Pallet::kick`].
        /// </summary>
        kick = 21,
        
        /// <summary>
        /// >> set_staking_configs
        /// See [`Pallet::set_staking_configs`].
        /// </summary>
        set_staking_configs = 22,
        
        /// <summary>
        /// >> chill_other
        /// See [`Pallet::chill_other`].
        /// </summary>
        chill_other = 23,
        
        /// <summary>
        /// >> force_apply_min_commission
        /// See [`Pallet::force_apply_min_commission`].
        /// </summary>
        force_apply_min_commission = 24,
        
        /// <summary>
        /// >> set_min_commission
        /// See [`Pallet::set_min_commission`].
        /// </summary>
        set_min_commission = 25,
        
        /// <summary>
        /// >> payout_stakers_by_page
        /// See [`Pallet::payout_stakers_by_page`].
        /// </summary>
        payout_stakers_by_page = 26,
    }
    
    /// <summary>
    /// >> 105 - Variant[pallet_staking.pallet.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.Gear.Api.Generated.Model.pallet_staking.EnumRewardDestination>>(Call.bond);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>(Call.bond_extra);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>(Call.unbond);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.withdraw_unbonded);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_staking.ValidatorPrefs>(Call.validate);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>(Call.nominate);
				AddTypeDecoder<BaseVoid>(Call.chill);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_staking.EnumRewardDestination>(Call.set_payee);
				AddTypeDecoder<BaseVoid>(Call.set_controller);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.set_validator_count);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.increase_validator_count);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Percent>(Call.scale_validator_count);
				AddTypeDecoder<BaseVoid>(Call.force_no_eras);
				AddTypeDecoder<BaseVoid>(Call.force_new_era);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>>(Call.set_invulnerables);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.force_unstake);
				AddTypeDecoder<BaseVoid>(Call.force_new_era_always);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>>>(Call.cancel_deferred_slash);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.payout_stakers);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>(Call.rebond);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.reap_stash);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>(Call.kick);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.pallet_staking.pallet.pallet.EnumConfigOp, Substrate.Gear.Api.Generated.Model.pallet_staking.pallet.pallet.EnumConfigOp, Substrate.Gear.Api.Generated.Model.pallet_staking.pallet.pallet.EnumConfigOp, Substrate.Gear.Api.Generated.Model.pallet_staking.pallet.pallet.EnumConfigOp, Substrate.Gear.Api.Generated.Model.pallet_staking.pallet.pallet.EnumConfigOp, Substrate.Gear.Api.Generated.Model.pallet_staking.pallet.pallet.EnumConfigOp>>(Call.set_staking_configs);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>(Call.chill_other);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>(Call.force_apply_min_commission);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perbill>(Call.set_min_commission);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.payout_stakers_by_page);
        }
    }
}