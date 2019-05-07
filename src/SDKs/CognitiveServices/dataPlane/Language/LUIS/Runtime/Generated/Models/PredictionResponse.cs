// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents the prediction response.
    /// </summary>
    public partial class PredictionResponse
    {
        /// <summary>
        /// Initializes a new instance of the PredictionResponse class.
        /// </summary>
        public PredictionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PredictionResponse class.
        /// </summary>
        /// <param name="query">The query used in the prediction.</param>
        /// <param name="prediction">The prediction of the requested
        /// query.</param>
        public PredictionResponse(string query, Prediction prediction)
        {
            Query = query;
            Prediction = prediction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the query used in the prediction.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets the prediction of the requested query.
        /// </summary>
        [JsonProperty(PropertyName = "prediction")]
        public Prediction Prediction { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Query == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Query");
            }
            if (Prediction == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Prediction");
            }
            if (Prediction != null)
            {
                Prediction.Validate();
            }
        }
    }
}