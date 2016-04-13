// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The type MessageCopyRequestBuilder.
    /// </summary>
    public partial class MessageCopyRequestBuilder : BaseRequestBuilder, IMessageCopyRequestBuilder
    {
    
        public MessageCopyRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string destinationId = null)
            : base(requestUrl, client)
        {
            
            this.DestinationId = destinationId;

        }
    
        /// <summary>
        /// Gets the value of DestinationId.
        /// </summary>
        public string DestinationId { get; set; }
    
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IMessageCopyRequest Request(IEnumerable<Option> options = null)
        {
                
            return new MessageCopyRequest(
                this.RequestUrl,
                this.Client,
                options,
                this.DestinationId);
        
        }

    }
}
