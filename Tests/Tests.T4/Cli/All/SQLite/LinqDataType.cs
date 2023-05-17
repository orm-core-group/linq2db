// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using System;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.SQLite
{
	[Table("LinqDataTypes")]
	public class LinqDataType
	{
		[Column("ID"            , DataType = DataType.Int32    , DbType = "int"             , Length = 4         , Precision = 10, Scale = 0)] public int?      Id             { get; set; } // int
		[Column("MoneyValue"    , DataType = DataType.Decimal  , DbType = "decimal"         , Length = 8         , Precision = 10, Scale = 4)] public decimal?  MoneyValue     { get; set; } // decimal
		[Column("DateTimeValue" , DataType = DataType.DateTime , DbType = "datetime"        , Length = 8         , Precision = 0 , Scale = 0)] public DateTime? DateTimeValue  { get; set; } // datetime
		[Column("DateTimeValue2", DataType = DataType.DateTime2, DbType = "datetime2"       , Length = 2147483647, Precision = 0 , Scale = 0)] public DateTime? DateTimeValue2 { get; set; } // datetime2
		[Column("BoolValue"     , DataType = DataType.Boolean  , DbType = "boolean"         , Length = 1         , Precision = 0 , Scale = 0)] public bool?     BoolValue      { get; set; } // boolean
		[Column("GuidValue"     , DataType = DataType.Guid     , DbType = "uniqueidentifier", Length = 16        , Precision = 0 , Scale = 0)] public Guid?     GuidValue      { get; set; } // uniqueidentifier
		[Column("BinaryValue"   , DataType = DataType.Binary   , DbType = "binary"          , Length = 5000      , Precision = 0 , Scale = 0)] public byte[]?   BinaryValue    { get; set; } // binary
		[Column("SmallIntValue" , DataType = DataType.Int16    , DbType = "smallint"        , Length = 2         , Precision = 5 , Scale = 0)] public short?    SmallIntValue  { get; set; } // smallint
		[Column("IntValue"      , DataType = DataType.Int32    , DbType = "int"             , Length = 4         , Precision = 10, Scale = 0)] public int?      IntValue       { get; set; } // int
		[Column("BigIntValue"   , DataType = DataType.Int64    , DbType = "bigint"          , Length = 8         , Precision = 19, Scale = 0)] public long?     BigIntValue    { get; set; } // bigint
		[Column("StringValue"   , DataType = DataType.NVarChar , DbType = "nvarchar(50)"    , Length = 50        , Precision = 0 , Scale = 0)] public string?   StringValue    { get; set; } // nvarchar(50)
	}
}