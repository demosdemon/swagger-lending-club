/* 
 * Lending Club API
 *
 * Lending Club API
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Defines InitialListStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InitialListStatus
    {
        
        /// <summary>
        /// Enum W for "W"
        /// </summary>
        [EnumMember(Value = "W")]
        W = 1,
        
        /// <summary>
        /// Enum F for "F"
        /// </summary>
        [EnumMember(Value = "F")]
        F = 2
    }

}
