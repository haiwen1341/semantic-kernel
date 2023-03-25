﻿// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Microsoft.SemanticKernel.AI.HuggingFace.HttpSchema;

/// <summary>
/// HTTP schema to perform embedding request.
/// </summary>
[Serializable]
public sealed class EmbeddingRequest
{
    /// <summary>
    /// Data to embed.
    /// </summary>
    [JsonPropertyName("input")]
    public IList<string> Input { get; set; } = new List<string>();

    /// <summary>
    /// Model to use for embedding generation.
    /// </summary>
    [JsonPropertyName("model")]
    public string Model { get; set; } = string.Empty;
}