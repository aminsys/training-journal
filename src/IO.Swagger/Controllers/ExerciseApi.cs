/*
 * Training Journal - OpenAPI 3.0
 *
 * This a personal training journal API Server based on the OpenAPI 3.0 specification.  ### GitHub repo of the project: - [My GitHub](https://github.com/aminsys/training-journal)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ExerciseApiController : ControllerBase
    { 
        /// <summary>
        /// Get user&#x27;s exercises related to the training session.
        /// </summary>
        /// <param name="trainingSessionId">Training session&#x27;s ID</param>
        /// <response code="200">successful request</response>
        /// <response code="404">Exercises not found for the the training session</response>
        [HttpGet]
        [Route("/api/v1/user/trainingSessions/{trainingSessionId}/exercises")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetExercisesByTrainingSessionId")]
        [SwaggerResponse(statusCode: 200, type: typeof(Exercises), description: "successful request")]
        public virtual IActionResult GetExercisesByTrainingSessionId([FromRoute][Required]long? trainingSessionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Exercises));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"exerciseName\" : \"Bench press\",\n  \"reps\" : 10,\n  \"exerciseId\" : 12,\n  \"sets\" : 2\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Exercises>(exampleJson)
                        : default(Exercises);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
