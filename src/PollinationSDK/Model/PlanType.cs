/* 
 * pollination-server
 *
 * Pollination Server OpenAPI Definition
 *
 * Contact: info@pollination.cloud
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonsoft;  extern alias LBTRestSharp; using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonsoft::Newtonsoft.Json;
using LBTNewtonsoft::Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace PollinationSDK
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    /// <value>An enumeration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PlanType
    {
        /// <summary>
        /// Enum Cloud for value: cloud
        /// </summary>
        [EnumMember(Value = "cloud")]
        Cloud = 1,

        /// <summary>
        /// Enum RhinoPlugin for value: rhino-plugin
        /// </summary>
        [EnumMember(Value = "rhino-plugin")]
        RhinoPlugin = 2,

        /// <summary>
        /// Enum RevitPlugin for value: revit-plugin
        /// </summary>
        [EnumMember(Value = "revit-plugin")]
        RevitPlugin = 3,

        /// <summary>
        /// Enum BundledPlugin for value: bundled-plugin
        /// </summary>
        [EnumMember(Value = "bundled-plugin")]
        BundledPlugin = 4,

        /// <summary>
        /// Enum Application for value: application
        /// </summary>
        [EnumMember(Value = "application")]
        Application = 5,

        /// <summary>
        /// Enum Seat for value: seat
        /// </summary>
        [EnumMember(Value = "seat")]
        Seat = 6,

        /// <summary>
        /// Enum CloudCompute for value: cloud-compute
        /// </summary>
        [EnumMember(Value = "cloud-compute")]
        CloudCompute = 7

    }

}
