﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gamevault.Models.Mapping
{
    internal class UpdateGameDto
    {
        /// <summary>
        /// The updated user metadata. If not provided, the user_metadata will not be updated.
        /// </summary>
        /// <value>The updated user metadata. If not provided, the user_metadata will not be updated.</value>
        [JsonPropertyName("user_metadata")]
        public GameMetadata? UserMetadata { get; set; }

        /// <summary>
        /// The mapping requests. If not provided, the game will not be remapped.
        /// </summary>
        /// <value>The mapping requests. If not provided, the game will not be remapped.</value>
        [JsonPropertyName("mapping_requests")]
        public MapGameDto? MappingRequests { get; set; }
    }
}
