﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SampleFunctionAppNew.Models
{
    public class UpdateModel
    {
        [JsonPropertyName("field_102")]
    public string LongText { get; set; }
    }
}
