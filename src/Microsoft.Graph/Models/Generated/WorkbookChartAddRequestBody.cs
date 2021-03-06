// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookChartAddRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookChartAddRequestBody
    {
    
        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets SourceData.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceData", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken SourceData { get; set; }
    
        /// <summary>
        /// Gets or sets SeriesBy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "seriesBy", Required = Newtonsoft.Json.Required.Default)]
        public string SeriesBy { get; set; }
    
    }
}
