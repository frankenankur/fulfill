/*
 * Shipments API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class DigitalGoodsApiController : Controller
    { 
        /// <summary>
        /// Digital Goods Fulfillment Status Update. (Auth policies: OrderFulfiller)
        /// </summary>
        
        /// <param name="partnerOrderNumber">The partner order number.</param>
        /// <param name="costcoTrackingId">Unique ID to Correlate HTTP requests between a client and server.</param>
        /// <param name="lineItems">The collection of items to process</param>
        /// <param name="costcoEnv">Non-Production Environment Identifier.</param>
        /// <response code="200">Status 200</response>
        /// <response code="400">Status 400</response>
        /// <response code="500">Status 500</response>
        [HttpPut]
        [Route("/shipments/v1/fulfillment/digitalgoods/orders/{partnerOrderNumber}")]
        [ValidateModelState]
        [SwaggerOperation("FulfillDigitalGoods")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse200), description: "Status 200")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiExceptionResponse), description: "Status 400")]
        [SwaggerResponse(statusCode: 500, type: typeof(GatewayError), description: "Status 500")]
        public virtual IActionResult FulfillDigitalGoods([FromRoute][Required]string partnerOrderNumber, [FromHeader][Required()]string costcoTrackingId, [FromBody]List<LineItem> lineItems, [FromHeader]string costcoEnv)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse200));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiExceptionResponse));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(GatewayError));

            string exampleJson = null;
            exampleJson = "{\n  \"result\" : \"ok\",\n  \"lineItems\" : [ {\n    \"itemNumber\" : 0.80082819046101150206595775671303272247314453125,\n    \"quantity\" : 6.02745618307040320615897144307382404804229736328125,\n    \"lineProcessingStatus\" : \"invalidItem\"\n  }, {\n    \"itemNumber\" : 0.80082819046101150206595775671303272247314453125,\n    \"quantity\" : 6.02745618307040320615897144307382404804229736328125,\n    \"lineProcessingStatus\" : \"invalidItem\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse200>(exampleJson)
            : default(InlineResponse200);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
