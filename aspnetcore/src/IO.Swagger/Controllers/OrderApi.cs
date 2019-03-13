/*
 * Costco Fulfillment API
 *
 * An API for fullfilling orders placed on non-Costco channels by Costco 
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
    public class OrderApiController : Controller
    { 
        /// <summary>
        /// Request Tip Adjustment
        /// </summary>
        /// <remarks>[Final]  </remarks>
        /// <param name="salesChannelId"></param>
        /// <param name="partnerOrderNumber"></param>
        /// <param name="costcoTrackingId">Unique ID to Correlate HTTP requests between a client and server.</param>
        /// <param name="body"></param>
        /// <param name="costcoEnv">Non-Production Environment Identifier</param>
        /// <response code="200">Status 200</response>
        /// <response code="400">Status 400</response>
        /// <response code="500">Status 500</response>
        [HttpPut]
        [Route("/ebusiness/{salesChannelId}/order/{partnerOrderNumber}/adjustTip")]
        [ValidateModelState]
        [SwaggerOperation("SalesChannelIdOrderPartnerOrderNumberAdjustTipPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse2006), description: "Status 200")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Status 400")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Status 500")]
        public virtual IActionResult SalesChannelIdOrderPartnerOrderNumberAdjustTipPut([FromRoute][Required]string salesChannelId, [FromRoute][Required]string partnerOrderNumber, [FromHeader][Required()]string costcoTrackingId, [FromBody]Body6 body, [FromHeader]string costcoEnv)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse2006));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));

            string exampleJson = null;
            exampleJson = "{\n  \"tipAdjustment\" : 0.80082819046101150206595775671303272247314453125,\n  \"status\" : \"invalidOrder\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse2006>(exampleJson)
            : default(InlineResponse2006);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Cancel an Order
        /// </summary>
        /// <remarks>[In Design] Attempts cancellation of an order being fullfilled at Costco</remarks>
        /// <param name="salesChannelId"></param>
        /// <param name="partnerOrderNumber"></param>
        /// <param name="reasonCode">The Costco Cancellation Reason Code  CUS - Customer Request FRD - Fraud DUP - Duplicate Order CCD - CC Decline on Re-Auth ERR - Error in processing Order ANO - Authorization not obtained/card decline OTH - Other</param>
        /// <param name="costcoTrackingId">Unique ID to Correlate HTTP requests between a client and server.</param>
        /// <param name="reason">Customer Service Notes Associated with Cancellation.  Required for Reason Codes ERR and OTH</param>
        /// <param name="costcoEnv">Non-Production Environment Identifier</param>
        /// <response code="200">Status 200</response>
        /// <response code="400">Status 400</response>
        /// <response code="500">Status 500</response>
        [HttpDelete]
        [Route("/ebusiness/{salesChannelId}/order/{partnerOrderNumber}")]
        [ValidateModelState]
        [SwaggerOperation("SalesChannelIdOrderPartnerOrderNumberDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "Status 200")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Status 400")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Status 500")]
        public virtual IActionResult SalesChannelIdOrderPartnerOrderNumberDelete([FromRoute][Required]string salesChannelId, [FromRoute][Required]string partnerOrderNumber, [FromQuery][Required()]string reasonCode, [FromHeader][Required()]string costcoTrackingId, [FromQuery] [MaxLength(500)]string reason, [FromHeader]string costcoEnv)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(string));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));

            string exampleJson = null;
            exampleJson = "\"OK\"";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Fulfill Order
        /// </summary>
        /// <remarks>[Final]  </remarks>
        /// <param name="salesChannelId"></param>
        /// <param name="partnerOrderNumber"></param>
        /// <param name="costcoTrackingId">Unique ID to Correlate HTTP requests between a client and server.</param>
        /// <param name="body"></param>
        /// <param name="costcoEnv">Non-Production Environment Identifier</param>
        /// <response code="200">Status 200</response>
        /// <response code="400">Status 400</response>
        /// <response code="500">Status 500</response>
        [HttpPost]
        [Route("/ebusiness/{salesChannelId}/order/{partnerOrderNumber}/fulfill")]
        [ValidateModelState]
        [SwaggerOperation("SalesChannelIdOrderPartnerOrderNumberFulfillPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse2005), description: "Status 200")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Status 400")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Status 500")]
        public virtual IActionResult SalesChannelIdOrderPartnerOrderNumberFulfillPost([FromRoute][Required]string salesChannelId, [FromRoute][Required]string partnerOrderNumber, [FromHeader][Required()]string costcoTrackingId, [FromBody]Body5 body, [FromHeader]string costcoEnv)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse2005));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));

            string exampleJson = null;
            exampleJson = "{\n  \"partnerOrder\" : {\n    \"lineItems\" : [ {\n      \"itemNumber\" : \"itemNumber\",\n      \"unitShippingTaxPrice\" : 4.1456080298839363962315474054776132106781005859375,\n      \"fees\" : [ {\n        \"quantity\" : 2,\n        \"feeDescription\" : [ {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        }, {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        } ],\n        \"taxable\" : true,\n        \"feeSKU\" : \"2123343122\",\n        \"feeUnitPrice\" : 0.4\n      }, {\n        \"quantity\" : 2,\n        \"feeDescription\" : [ {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        }, {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        } ],\n        \"taxable\" : true,\n        \"feeSKU\" : \"2123343122\",\n        \"feeUnitPrice\" : 0.4\n      } ],\n      \"quantity\" : 2,\n      \"unitPriceMarkupAmount\" : 9.301444243932575517419536481611430644989013671875,\n      \"referenceNumber\" : 5.63737665663332876420099637471139430999755859375,\n      \"unitItemTaxPrice\" : 3.61607674925191080461672754609026014804840087890625,\n      \"unitSellPrice\" : 7.061401241503109105224211816675961017608642578125,\n      \"unitShippingPrice\" : 2.027123023002321833274663731572218239307403564453125,\n      \"lineProcessingStatus\" : \"invalidBarCodeScanned\"\n    }, {\n      \"itemNumber\" : \"itemNumber\",\n      \"unitShippingTaxPrice\" : 4.1456080298839363962315474054776132106781005859375,\n      \"fees\" : [ {\n        \"quantity\" : 2,\n        \"feeDescription\" : [ {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        }, {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        } ],\n        \"taxable\" : true,\n        \"feeSKU\" : \"2123343122\",\n        \"feeUnitPrice\" : 0.4\n      }, {\n        \"quantity\" : 2,\n        \"feeDescription\" : [ {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        }, {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        } ],\n        \"taxable\" : true,\n        \"feeSKU\" : \"2123343122\",\n        \"feeUnitPrice\" : 0.4\n      } ],\n      \"quantity\" : 2,\n      \"unitPriceMarkupAmount\" : 9.301444243932575517419536481611430644989013671875,\n      \"referenceNumber\" : 5.63737665663332876420099637471139430999755859375,\n      \"unitItemTaxPrice\" : 3.61607674925191080461672754609026014804840087890625,\n      \"unitSellPrice\" : 7.061401241503109105224211816675961017608642578125,\n      \"unitShippingPrice\" : 2.027123023002321833274663731572218239307403564453125,\n      \"lineProcessingStatus\" : \"invalidBarCodeScanned\"\n    } ],\n    \"orderStatus\" : \"new\",\n    \"orderSummary\" : {\n      \"placeOrderTime\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"shippingTotal\" : 1.46581298050294517310021547018550336360931396484375,\n      \"tipTotal\" : 5.962133916683182377482808078639209270477294921875,\n      \"subtotal\" : 0.80082819046101150206595775671303272247314453125,\n      \"partnerOrderNumber\" : \"partnerOrderNumber\",\n      \"taxTotal\" : 6.02745618307040320615897144307382404804229736328125,\n      \"currency\" : \"USD\"\n    }\n  },\n  \"requestStatus\" : \"ok\",\n  \"barCode\" : \"barCode\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse2005>(exampleJson)
            : default(InlineResponse2005);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Notification of Status Change
        /// </summary>
        /// <remarks>[Final]</remarks>
        /// <param name="salesChannelId"></param>
        /// <param name="partnerOrderNumber"></param>
        /// <param name="costcoTrackingId">Unique ID to Correlate HTTP requests between a client and server.</param>
        /// <param name="body"></param>
        /// <param name="costcoEnv">Non-Production Environment Identifier</param>
        /// <response code="200">Status 200</response>
        /// <response code="400">Status 400</response>
        /// <response code="500">Status 500</response>
        [HttpPut]
        [Route("/ebusiness/{salesChannelId}/order/{partnerOrderNumber}/fulfill")]
        [ValidateModelState]
        [SwaggerOperation("SalesChannelIdOrderPartnerOrderNumberFulfillPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse2004), description: "Status 200")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Status 400")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Status 500")]
        public virtual IActionResult SalesChannelIdOrderPartnerOrderNumberFulfillPut([FromRoute][Required]string salesChannelId, [FromRoute][Required]string partnerOrderNumber, [FromHeader][Required()]string costcoTrackingId, [FromBody]Body4 body, [FromHeader]string costcoEnv)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse2004));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));

            string exampleJson = null;
            exampleJson = "{\n  \"result\" : \"OK\",\n  \"partnerOrder\" : {\n    \"lineItems\" : {\n      \"itemNumber\" : \"itemNumber\",\n      \"unitShippingTaxPrice\" : 2.027123023002321833274663731572218239307403564453125,\n      \"fees\" : {\n        \"quantity\" : 2,\n        \"feeDescription\" : [ {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        }, {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        } ],\n        \"taxable\" : true,\n        \"feeSKU\" : \"2123343122\",\n        \"feeUnitPrice\" : 0.4\n      },\n      \"quantity\" : 2,\n      \"unitPriceMarkupAmount\" : 9.301444243932575517419536481611430644989013671875,\n      \"referenceNumber\" : 5.63737665663332876420099637471139430999755859375,\n      \"unitSellPrice\" : 7.061401241503109105224211816675961017608642578125,\n      \"unitShippingPrice\" : 3.61607674925191080461672754609026014804840087890625,\n      \"lineProcessingStatus\" : \"invalidBarCodeScanned\"\n    },\n    \"orderSummary\" : {\n      \"placeOrderTime\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"shippingTotal\" : 1.46581298050294517310021547018550336360931396484375,\n      \"tipTotal\" : 5.962133916683182377482808078639209270477294921875,\n      \"subtotal\" : 0.80082819046101150206595775671303272247314453125,\n      \"partnerOrderNumber\" : \"partnerOrderNumber\",\n      \"taxTotal\" : 6.02745618307040320615897144307382404804229736328125,\n      \"currency\" : \"USD\"\n    }\n  },\n  \"undeliveredItemsPartnerOrderNumber\" : \"undeliveredItemsPartnerOrderNumber\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse2004>(exampleJson)
            : default(InlineResponse2004);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Retrieve Order Details
        /// </summary>
        /// <remarks>[Final]  Returns Order Line Details</remarks>
        /// <param name="salesChannelId"></param>
        /// <param name="partnerOrderNumber"></param>
        /// <param name="costcoTrackingId">Unique ID to Correlate HTTP requests between a client and server.</param>
        /// <param name="costcoEnv">Non-Production Environment Identifier</param>
        /// <response code="200">Status 200</response>
        /// <response code="400">Status 400</response>
        /// <response code="500">Status 500</response>
        [HttpGet]
        [Route("/ebusiness/{salesChannelId}/order/{partnerOrderNumber}")]
        [ValidateModelState]
        [SwaggerOperation("SalesChannelIdOrderPartnerOrderNumberGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse2003), description: "Status 200")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Status 400")]
        [SwaggerResponse(statusCode: 500, type: typeof(InlineResponse500), description: "Status 500")]
        public virtual IActionResult SalesChannelIdOrderPartnerOrderNumberGet([FromRoute][Required]string salesChannelId, [FromRoute][Required]string partnerOrderNumber, [FromHeader][Required()]string costcoTrackingId, [FromHeader]string costcoEnv)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse2003));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(InlineResponse500));

            string exampleJson = null;
            exampleJson = "{\n  \"partnerOrder\" : {\n    \"lineItems\" : [ {\n      \"itemNumber\" : \"itemNumber\",\n      \"unitShippingTaxPrice\" : 4.1456080298839363962315474054776132106781005859375,\n      \"fees\" : [ {\n        \"quantity\" : 2,\n        \"feeDescription\" : [ {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        }, {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        } ],\n        \"taxable\" : true,\n        \"feeSKU\" : \"2123343122\",\n        \"feeUnitPrice\" : 0.4\n      }, {\n        \"quantity\" : 2,\n        \"feeDescription\" : [ {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        }, {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        } ],\n        \"taxable\" : true,\n        \"feeSKU\" : \"2123343122\",\n        \"feeUnitPrice\" : 0.4\n      } ],\n      \"quantity\" : 2,\n      \"unitPriceMarkupAmount\" : 9.301444243932575517419536481611430644989013671875,\n      \"referenceNumber\" : 5.63737665663332876420099637471139430999755859375,\n      \"unitItemTaxPrice\" : 3.61607674925191080461672754609026014804840087890625,\n      \"lineItemStatuses\" : [ {\n        \"quantity\" : 7.3862819483858839220147274318151175975799560546875,\n        \"status\" : \"delivered\"\n      }, {\n        \"quantity\" : 7.3862819483858839220147274318151175975799560546875,\n        \"status\" : \"delivered\"\n      } ],\n      \"unitSellPrice\" : 7.061401241503109105224211816675961017608642578125,\n      \"unitShippingPrice\" : 2.027123023002321833274663731572218239307403564453125\n    }, {\n      \"itemNumber\" : \"itemNumber\",\n      \"unitShippingTaxPrice\" : 4.1456080298839363962315474054776132106781005859375,\n      \"fees\" : [ {\n        \"quantity\" : 2,\n        \"feeDescription\" : [ {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        }, {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        } ],\n        \"taxable\" : true,\n        \"feeSKU\" : \"2123343122\",\n        \"feeUnitPrice\" : 0.4\n      }, {\n        \"quantity\" : 2,\n        \"feeDescription\" : [ {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        }, {\n          \"description\" : \"description\",\n          \"locale\" : \"locale\"\n        } ],\n        \"taxable\" : true,\n        \"feeSKU\" : \"2123343122\",\n        \"feeUnitPrice\" : 0.4\n      } ],\n      \"quantity\" : 2,\n      \"unitPriceMarkupAmount\" : 9.301444243932575517419536481611430644989013671875,\n      \"referenceNumber\" : 5.63737665663332876420099637471139430999755859375,\n      \"unitItemTaxPrice\" : 3.61607674925191080461672754609026014804840087890625,\n      \"lineItemStatuses\" : [ {\n        \"quantity\" : 7.3862819483858839220147274318151175975799560546875,\n        \"status\" : \"delivered\"\n      }, {\n        \"quantity\" : 7.3862819483858839220147274318151175975799560546875,\n        \"status\" : \"delivered\"\n      } ],\n      \"unitSellPrice\" : 7.061401241503109105224211816675961017608642578125,\n      \"unitShippingPrice\" : 2.027123023002321833274663731572218239307403564453125\n    } ],\n    \"orderStatus\" : \"new\",\n    \"orderSummary\" : {\n      \"placeOrderTime\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"shippingTotal\" : 1.46581298050294517310021547018550336360931396484375,\n      \"tipTotal\" : 5.962133916683182377482808078639209270477294921875,\n      \"subtotal\" : 0.80082819046101150206595775671303272247314453125,\n      \"partnerOrderNumber\" : \"partnerOrderNumber\",\n      \"taxTotal\" : 6.02745618307040320615897144307382404804229736328125,\n      \"currency\" : \"currency\"\n    }\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse2003>(exampleJson)
            : default(InlineResponse2003);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Notification of Customer Refund
        /// </summary>
        /// <remarks>[In Design] </remarks>
        /// <param name="salesChannelId"></param>
        /// <param name="partnerOrderNumber"></param>
        /// <param name="costcoTrackingId">Unique ID to Correlate HTTP requests between a client and server.</param>
        /// <param name="body"></param>
        /// <param name="costcoEnv">Non-Production Environment Identifier</param>
        /// <response code="200">Status 200</response>
        /// <response code="400">Status 400</response>
        /// <response code="500">Status 500</response>
        [HttpPost]
        [Route("/ebusiness/{salesChannelId}/order/{partnerOrderNumber}/refund")]
        [ValidateModelState]
        [SwaggerOperation("SalesChannelIdOrderPartnerOrderNumberRefundPost")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Status 400")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Status 500")]
        public virtual IActionResult SalesChannelIdOrderPartnerOrderNumberRefundPost([FromRoute][Required]string salesChannelId, [FromRoute][Required]string partnerOrderNumber, [FromHeader][Required()]string costcoTrackingId, [FromBody]Body3 body, [FromHeader]string costcoEnv)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));


            throw new NotImplementedException();
        }

        /// <summary>
        /// Request Return Authorization
        /// </summary>
        /// <remarks>[Final]</remarks>
        /// <param name="salesChannelId"></param>
        /// <param name="partnerOrderNumber"></param>
        /// <param name="costcoTrackingId">Unique ID to Correlate HTTP requests between a client and server.</param>
        /// <param name="body"></param>
        /// <param name="costcoEnv">Non-Production Environment Identifier</param>
        /// <response code="200">Status 200</response>
        /// <response code="400">Status 400</response>
        /// <response code="500">Status 500</response>
        [HttpPost]
        [Route("/ebusiness/{salesChannelId}/order/{partnerOrderNumber}/return")]
        [ValidateModelState]
        [SwaggerOperation("SalesChannelIdOrderPartnerOrderNumberReturnPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ReturnAuthorization), description: "Status 200")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Status 400")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Status 500")]
        public virtual IActionResult SalesChannelIdOrderPartnerOrderNumberReturnPost([FromRoute][Required]string salesChannelId, [FromRoute][Required]string partnerOrderNumber, [FromHeader][Required()]string costcoTrackingId, [FromBody]Body2 body, [FromHeader]string costcoEnv)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ReturnAuthorization));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));

            string exampleJson = null;
            exampleJson = "{\n  \"executionStatus\" : \"executed\",\n  \"partnerAuthorizationNumber\" : \"partnerAuthorizationNumber\",\n  \"returnDispositions\" : [ {\n    \"dispositionType\" : \"CallTag\",\n    \"carrier\" : \"carrier\",\n    \"orderLines\" : [ {\n      \"itemNumber\" : \"itemNumber\",\n      \"quantity\" : 0\n    }, {\n      \"itemNumber\" : \"itemNumber\",\n      \"quantity\" : 0\n    } ],\n    \"shippingLabel\" : \"shippingLabel\",\n    \"trackingId\" : \"trackingId\"\n  }, {\n    \"dispositionType\" : \"CallTag\",\n    \"carrier\" : \"carrier\",\n    \"orderLines\" : [ {\n      \"itemNumber\" : \"itemNumber\",\n      \"quantity\" : 0\n    }, {\n      \"itemNumber\" : \"itemNumber\",\n      \"quantity\" : 0\n    } ],\n    \"shippingLabel\" : \"shippingLabel\",\n    \"trackingId\" : \"trackingId\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ReturnAuthorization>(exampleJson)
            : default(ReturnAuthorization);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create an Order Async
        /// </summary>
        /// <remarks>[Final] Creates an Order at Costco to be fulfilled</remarks>
        /// <param name="salesChannelId"></param>
        /// <param name="costcoTrackingId">Unique ID to Correlate HTTP requests between a client and server.</param>
        /// <param name="body"></param>
        /// <param name="costcoEnv">Non-Production Environment Identifier</param>
        /// <response code="200">Status 200</response>
        /// <response code="400">Status 400</response>
        /// <response code="500">Status 500</response>
        [HttpPost]
        [Route("/ebusiness/{salesChannelId}/order")]
        [ValidateModelState]
        [SwaggerOperation("SalesChannelIdOrderPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse2002), description: "Status 200")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Status 400")]
        [SwaggerResponse(statusCode: 500, type: typeof(InlineResponse500), description: "Status 500")]
        public virtual IActionResult SalesChannelIdOrderPost([FromRoute][Required]string salesChannelId, [FromHeader][Required()]string costcoTrackingId, [FromBody]PartnerOrder body, [FromHeader]string costcoEnv)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse2002));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(InlineResponse500));

            string exampleJson = null;
            exampleJson = "{\n  \"received\" : true\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse2002>(exampleJson)
            : default(InlineResponse2002);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
