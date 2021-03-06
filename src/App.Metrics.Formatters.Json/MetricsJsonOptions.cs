﻿// <copyright file="MetricsJsonOptions.cs" company="App Metrics Contributors">
// Copyright (c) App Metrics Contributors. All rights reserved.
// </copyright>

using Newtonsoft.Json;

namespace App.Metrics.Formatters.Json
{
    /// <summary>
    ///     Provides programmatic configuration for JSON formatting the App Metrics framework.
    /// </summary>
    public class MetricsJsonOptions
    {
        public JsonSerializerSettings SerializerSettings { get; } =
            DefaultJsonSerializerSettings.CreateSerializerSettings();
    }
}
