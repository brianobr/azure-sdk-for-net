// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CachingType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CachingType
    {
        /// <summary>
        /// The caching mode for the disk is not enabled.
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        /// <summary>
        /// The caching mode for the disk is read only.
        /// </summary>
        [EnumMember(Value = "ReadOnly")]
        ReadOnly,
        /// <summary>
        /// The caching mode for the disk is read and write.
        /// </summary>
        [EnumMember(Value = "ReadWrite")]
        ReadWrite
    }
    internal static class CachingTypeEnumExtension
    {
        internal static string ToSerializedValue(this CachingType? value)
        {
            return value == null ? null : ((CachingType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CachingType value)
        {
            switch( value )
            {
                case CachingType.None:
                    return "None";
                case CachingType.ReadOnly:
                    return "ReadOnly";
                case CachingType.ReadWrite:
                    return "ReadWrite";
            }
            return null;
        }

        internal static CachingType? ParseCachingType(this string value)
        {
            switch( value )
            {
                case "None":
                    return CachingType.None;
                case "ReadOnly":
                    return CachingType.ReadOnly;
                case "ReadWrite":
                    return CachingType.ReadWrite;
            }
            return null;
        }
    }
}
