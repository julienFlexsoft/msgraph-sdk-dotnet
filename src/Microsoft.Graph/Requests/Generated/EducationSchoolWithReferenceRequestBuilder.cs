// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EducationSchoolWithReferenceRequestBuilder.
    /// </summary>
    public partial class EducationSchoolWithReferenceRequestBuilder : BaseRequestBuilder, IEducationSchoolWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new EducationSchoolWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationSchoolWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEducationSchoolWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEducationSchoolWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new EducationSchoolWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the educationSchool.
        /// </summary>
        /// <returns>The <see cref="IEducationSchoolReferenceRequestBuilder"/>.</returns>
        public IEducationSchoolReferenceRequestBuilder Reference
        {
            get
            {
                return new EducationSchoolReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
