//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Substrate.Gear.Api.Generated.Model.pallet_gear.schedule
{
    
    
    /// <summary>
    /// >> 619 - Composite[pallet_gear.schedule.InstructionWeights]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class InstructionWeights : BaseType
    {
        
        /// <summary>
        /// >> version
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Version { get; set; }
        /// <summary>
        /// >> i64const
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64const { get; set; }
        /// <summary>
        /// >> i64load
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64load { get; set; }
        /// <summary>
        /// >> i32load
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32load { get; set; }
        /// <summary>
        /// >> i64store
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64store { get; set; }
        /// <summary>
        /// >> i32store
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32store { get; set; }
        /// <summary>
        /// >> select
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Select { get; set; }
        /// <summary>
        /// >> r#if
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 RHif { get; set; }
        /// <summary>
        /// >> br
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Br { get; set; }
        /// <summary>
        /// >> br_if
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 BrIf { get; set; }
        /// <summary>
        /// >> br_table
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 BrTable { get; set; }
        /// <summary>
        /// >> br_table_per_entry
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 BrTablePerEntry { get; set; }
        /// <summary>
        /// >> call
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Call { get; set; }
        /// <summary>
        /// >> call_indirect
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 CallIndirect { get; set; }
        /// <summary>
        /// >> call_indirect_per_param
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 CallIndirectPerParam { get; set; }
        /// <summary>
        /// >> call_per_local
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 CallPerLocal { get; set; }
        /// <summary>
        /// >> local_get
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 LocalGet { get; set; }
        /// <summary>
        /// >> local_set
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 LocalSet { get; set; }
        /// <summary>
        /// >> local_tee
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 LocalTee { get; set; }
        /// <summary>
        /// >> global_get
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GlobalGet { get; set; }
        /// <summary>
        /// >> global_set
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GlobalSet { get; set; }
        /// <summary>
        /// >> memory_current
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MemoryCurrent { get; set; }
        /// <summary>
        /// >> i64clz
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64clz { get; set; }
        /// <summary>
        /// >> i32clz
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32clz { get; set; }
        /// <summary>
        /// >> i64ctz
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64ctz { get; set; }
        /// <summary>
        /// >> i32ctz
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32ctz { get; set; }
        /// <summary>
        /// >> i64popcnt
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64popcnt { get; set; }
        /// <summary>
        /// >> i32popcnt
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32popcnt { get; set; }
        /// <summary>
        /// >> i64eqz
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64eqz { get; set; }
        /// <summary>
        /// >> i32eqz
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32eqz { get; set; }
        /// <summary>
        /// >> i32extend8s
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32extend8s { get; set; }
        /// <summary>
        /// >> i32extend16s
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32extend16s { get; set; }
        /// <summary>
        /// >> i64extend8s
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64extend8s { get; set; }
        /// <summary>
        /// >> i64extend16s
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64extend16s { get; set; }
        /// <summary>
        /// >> i64extend32s
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64extend32s { get; set; }
        /// <summary>
        /// >> i64extendsi32
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64extendsi32 { get; set; }
        /// <summary>
        /// >> i64extendui32
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64extendui32 { get; set; }
        /// <summary>
        /// >> i32wrapi64
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32wrapi64 { get; set; }
        /// <summary>
        /// >> i64eq
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64eq { get; set; }
        /// <summary>
        /// >> i32eq
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32eq { get; set; }
        /// <summary>
        /// >> i64ne
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64ne { get; set; }
        /// <summary>
        /// >> i32ne
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32ne { get; set; }
        /// <summary>
        /// >> i64lts
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64lts { get; set; }
        /// <summary>
        /// >> i32lts
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32lts { get; set; }
        /// <summary>
        /// >> i64ltu
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64ltu { get; set; }
        /// <summary>
        /// >> i32ltu
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32ltu { get; set; }
        /// <summary>
        /// >> i64gts
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64gts { get; set; }
        /// <summary>
        /// >> i32gts
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32gts { get; set; }
        /// <summary>
        /// >> i64gtu
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64gtu { get; set; }
        /// <summary>
        /// >> i32gtu
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32gtu { get; set; }
        /// <summary>
        /// >> i64les
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64les { get; set; }
        /// <summary>
        /// >> i32les
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32les { get; set; }
        /// <summary>
        /// >> i64leu
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64leu { get; set; }
        /// <summary>
        /// >> i32leu
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32leu { get; set; }
        /// <summary>
        /// >> i64ges
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64ges { get; set; }
        /// <summary>
        /// >> i32ges
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32ges { get; set; }
        /// <summary>
        /// >> i64geu
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64geu { get; set; }
        /// <summary>
        /// >> i32geu
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32geu { get; set; }
        /// <summary>
        /// >> i64add
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64add { get; set; }
        /// <summary>
        /// >> i32add
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32add { get; set; }
        /// <summary>
        /// >> i64sub
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64sub { get; set; }
        /// <summary>
        /// >> i32sub
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32sub { get; set; }
        /// <summary>
        /// >> i64mul
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64mul { get; set; }
        /// <summary>
        /// >> i32mul
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32mul { get; set; }
        /// <summary>
        /// >> i64divs
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64divs { get; set; }
        /// <summary>
        /// >> i32divs
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32divs { get; set; }
        /// <summary>
        /// >> i64divu
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64divu { get; set; }
        /// <summary>
        /// >> i32divu
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32divu { get; set; }
        /// <summary>
        /// >> i64rems
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64rems { get; set; }
        /// <summary>
        /// >> i32rems
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32rems { get; set; }
        /// <summary>
        /// >> i64remu
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64remu { get; set; }
        /// <summary>
        /// >> i32remu
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32remu { get; set; }
        /// <summary>
        /// >> i64and
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64and { get; set; }
        /// <summary>
        /// >> i32and
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32and { get; set; }
        /// <summary>
        /// >> i64or
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64or { get; set; }
        /// <summary>
        /// >> i32or
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32or { get; set; }
        /// <summary>
        /// >> i64xor
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64xor { get; set; }
        /// <summary>
        /// >> i32xor
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32xor { get; set; }
        /// <summary>
        /// >> i64shl
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64shl { get; set; }
        /// <summary>
        /// >> i32shl
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32shl { get; set; }
        /// <summary>
        /// >> i64shrs
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64shrs { get; set; }
        /// <summary>
        /// >> i32shrs
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32shrs { get; set; }
        /// <summary>
        /// >> i64shru
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64shru { get; set; }
        /// <summary>
        /// >> i32shru
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32shru { get; set; }
        /// <summary>
        /// >> i64rotl
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64rotl { get; set; }
        /// <summary>
        /// >> i32rotl
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32rotl { get; set; }
        /// <summary>
        /// >> i64rotr
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I64rotr { get; set; }
        /// <summary>
        /// >> i32rotr
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 I32rotr { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "InstructionWeights";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Version.Encode());
            result.AddRange(I64const.Encode());
            result.AddRange(I64load.Encode());
            result.AddRange(I32load.Encode());
            result.AddRange(I64store.Encode());
            result.AddRange(I32store.Encode());
            result.AddRange(Select.Encode());
            result.AddRange(RHif.Encode());
            result.AddRange(Br.Encode());
            result.AddRange(BrIf.Encode());
            result.AddRange(BrTable.Encode());
            result.AddRange(BrTablePerEntry.Encode());
            result.AddRange(Call.Encode());
            result.AddRange(CallIndirect.Encode());
            result.AddRange(CallIndirectPerParam.Encode());
            result.AddRange(CallPerLocal.Encode());
            result.AddRange(LocalGet.Encode());
            result.AddRange(LocalSet.Encode());
            result.AddRange(LocalTee.Encode());
            result.AddRange(GlobalGet.Encode());
            result.AddRange(GlobalSet.Encode());
            result.AddRange(MemoryCurrent.Encode());
            result.AddRange(I64clz.Encode());
            result.AddRange(I32clz.Encode());
            result.AddRange(I64ctz.Encode());
            result.AddRange(I32ctz.Encode());
            result.AddRange(I64popcnt.Encode());
            result.AddRange(I32popcnt.Encode());
            result.AddRange(I64eqz.Encode());
            result.AddRange(I32eqz.Encode());
            result.AddRange(I32extend8s.Encode());
            result.AddRange(I32extend16s.Encode());
            result.AddRange(I64extend8s.Encode());
            result.AddRange(I64extend16s.Encode());
            result.AddRange(I64extend32s.Encode());
            result.AddRange(I64extendsi32.Encode());
            result.AddRange(I64extendui32.Encode());
            result.AddRange(I32wrapi64.Encode());
            result.AddRange(I64eq.Encode());
            result.AddRange(I32eq.Encode());
            result.AddRange(I64ne.Encode());
            result.AddRange(I32ne.Encode());
            result.AddRange(I64lts.Encode());
            result.AddRange(I32lts.Encode());
            result.AddRange(I64ltu.Encode());
            result.AddRange(I32ltu.Encode());
            result.AddRange(I64gts.Encode());
            result.AddRange(I32gts.Encode());
            result.AddRange(I64gtu.Encode());
            result.AddRange(I32gtu.Encode());
            result.AddRange(I64les.Encode());
            result.AddRange(I32les.Encode());
            result.AddRange(I64leu.Encode());
            result.AddRange(I32leu.Encode());
            result.AddRange(I64ges.Encode());
            result.AddRange(I32ges.Encode());
            result.AddRange(I64geu.Encode());
            result.AddRange(I32geu.Encode());
            result.AddRange(I64add.Encode());
            result.AddRange(I32add.Encode());
            result.AddRange(I64sub.Encode());
            result.AddRange(I32sub.Encode());
            result.AddRange(I64mul.Encode());
            result.AddRange(I32mul.Encode());
            result.AddRange(I64divs.Encode());
            result.AddRange(I32divs.Encode());
            result.AddRange(I64divu.Encode());
            result.AddRange(I32divu.Encode());
            result.AddRange(I64rems.Encode());
            result.AddRange(I32rems.Encode());
            result.AddRange(I64remu.Encode());
            result.AddRange(I32remu.Encode());
            result.AddRange(I64and.Encode());
            result.AddRange(I32and.Encode());
            result.AddRange(I64or.Encode());
            result.AddRange(I32or.Encode());
            result.AddRange(I64xor.Encode());
            result.AddRange(I32xor.Encode());
            result.AddRange(I64shl.Encode());
            result.AddRange(I32shl.Encode());
            result.AddRange(I64shrs.Encode());
            result.AddRange(I32shrs.Encode());
            result.AddRange(I64shru.Encode());
            result.AddRange(I32shru.Encode());
            result.AddRange(I64rotl.Encode());
            result.AddRange(I32rotl.Encode());
            result.AddRange(I64rotr.Encode());
            result.AddRange(I32rotr.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Version = new Substrate.NetApi.Model.Types.Primitive.U32();
            Version.Decode(byteArray, ref p);
            I64const = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64const.Decode(byteArray, ref p);
            I64load = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64load.Decode(byteArray, ref p);
            I32load = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32load.Decode(byteArray, ref p);
            I64store = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64store.Decode(byteArray, ref p);
            I32store = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32store.Decode(byteArray, ref p);
            Select = new Substrate.NetApi.Model.Types.Primitive.U32();
            Select.Decode(byteArray, ref p);
            RHif = new Substrate.NetApi.Model.Types.Primitive.U32();
            RHif.Decode(byteArray, ref p);
            Br = new Substrate.NetApi.Model.Types.Primitive.U32();
            Br.Decode(byteArray, ref p);
            BrIf = new Substrate.NetApi.Model.Types.Primitive.U32();
            BrIf.Decode(byteArray, ref p);
            BrTable = new Substrate.NetApi.Model.Types.Primitive.U32();
            BrTable.Decode(byteArray, ref p);
            BrTablePerEntry = new Substrate.NetApi.Model.Types.Primitive.U32();
            BrTablePerEntry.Decode(byteArray, ref p);
            Call = new Substrate.NetApi.Model.Types.Primitive.U32();
            Call.Decode(byteArray, ref p);
            CallIndirect = new Substrate.NetApi.Model.Types.Primitive.U32();
            CallIndirect.Decode(byteArray, ref p);
            CallIndirectPerParam = new Substrate.NetApi.Model.Types.Primitive.U32();
            CallIndirectPerParam.Decode(byteArray, ref p);
            CallPerLocal = new Substrate.NetApi.Model.Types.Primitive.U32();
            CallPerLocal.Decode(byteArray, ref p);
            LocalGet = new Substrate.NetApi.Model.Types.Primitive.U32();
            LocalGet.Decode(byteArray, ref p);
            LocalSet = new Substrate.NetApi.Model.Types.Primitive.U32();
            LocalSet.Decode(byteArray, ref p);
            LocalTee = new Substrate.NetApi.Model.Types.Primitive.U32();
            LocalTee.Decode(byteArray, ref p);
            GlobalGet = new Substrate.NetApi.Model.Types.Primitive.U32();
            GlobalGet.Decode(byteArray, ref p);
            GlobalSet = new Substrate.NetApi.Model.Types.Primitive.U32();
            GlobalSet.Decode(byteArray, ref p);
            MemoryCurrent = new Substrate.NetApi.Model.Types.Primitive.U32();
            MemoryCurrent.Decode(byteArray, ref p);
            I64clz = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64clz.Decode(byteArray, ref p);
            I32clz = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32clz.Decode(byteArray, ref p);
            I64ctz = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64ctz.Decode(byteArray, ref p);
            I32ctz = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32ctz.Decode(byteArray, ref p);
            I64popcnt = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64popcnt.Decode(byteArray, ref p);
            I32popcnt = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32popcnt.Decode(byteArray, ref p);
            I64eqz = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64eqz.Decode(byteArray, ref p);
            I32eqz = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32eqz.Decode(byteArray, ref p);
            I32extend8s = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32extend8s.Decode(byteArray, ref p);
            I32extend16s = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32extend16s.Decode(byteArray, ref p);
            I64extend8s = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64extend8s.Decode(byteArray, ref p);
            I64extend16s = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64extend16s.Decode(byteArray, ref p);
            I64extend32s = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64extend32s.Decode(byteArray, ref p);
            I64extendsi32 = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64extendsi32.Decode(byteArray, ref p);
            I64extendui32 = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64extendui32.Decode(byteArray, ref p);
            I32wrapi64 = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32wrapi64.Decode(byteArray, ref p);
            I64eq = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64eq.Decode(byteArray, ref p);
            I32eq = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32eq.Decode(byteArray, ref p);
            I64ne = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64ne.Decode(byteArray, ref p);
            I32ne = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32ne.Decode(byteArray, ref p);
            I64lts = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64lts.Decode(byteArray, ref p);
            I32lts = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32lts.Decode(byteArray, ref p);
            I64ltu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64ltu.Decode(byteArray, ref p);
            I32ltu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32ltu.Decode(byteArray, ref p);
            I64gts = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64gts.Decode(byteArray, ref p);
            I32gts = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32gts.Decode(byteArray, ref p);
            I64gtu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64gtu.Decode(byteArray, ref p);
            I32gtu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32gtu.Decode(byteArray, ref p);
            I64les = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64les.Decode(byteArray, ref p);
            I32les = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32les.Decode(byteArray, ref p);
            I64leu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64leu.Decode(byteArray, ref p);
            I32leu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32leu.Decode(byteArray, ref p);
            I64ges = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64ges.Decode(byteArray, ref p);
            I32ges = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32ges.Decode(byteArray, ref p);
            I64geu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64geu.Decode(byteArray, ref p);
            I32geu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32geu.Decode(byteArray, ref p);
            I64add = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64add.Decode(byteArray, ref p);
            I32add = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32add.Decode(byteArray, ref p);
            I64sub = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64sub.Decode(byteArray, ref p);
            I32sub = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32sub.Decode(byteArray, ref p);
            I64mul = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64mul.Decode(byteArray, ref p);
            I32mul = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32mul.Decode(byteArray, ref p);
            I64divs = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64divs.Decode(byteArray, ref p);
            I32divs = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32divs.Decode(byteArray, ref p);
            I64divu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64divu.Decode(byteArray, ref p);
            I32divu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32divu.Decode(byteArray, ref p);
            I64rems = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64rems.Decode(byteArray, ref p);
            I32rems = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32rems.Decode(byteArray, ref p);
            I64remu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64remu.Decode(byteArray, ref p);
            I32remu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32remu.Decode(byteArray, ref p);
            I64and = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64and.Decode(byteArray, ref p);
            I32and = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32and.Decode(byteArray, ref p);
            I64or = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64or.Decode(byteArray, ref p);
            I32or = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32or.Decode(byteArray, ref p);
            I64xor = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64xor.Decode(byteArray, ref p);
            I32xor = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32xor.Decode(byteArray, ref p);
            I64shl = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64shl.Decode(byteArray, ref p);
            I32shl = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32shl.Decode(byteArray, ref p);
            I64shrs = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64shrs.Decode(byteArray, ref p);
            I32shrs = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32shrs.Decode(byteArray, ref p);
            I64shru = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64shru.Decode(byteArray, ref p);
            I32shru = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32shru.Decode(byteArray, ref p);
            I64rotl = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64rotl.Decode(byteArray, ref p);
            I32rotl = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32rotl.Decode(byteArray, ref p);
            I64rotr = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64rotr.Decode(byteArray, ref p);
            I32rotr = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32rotr.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}