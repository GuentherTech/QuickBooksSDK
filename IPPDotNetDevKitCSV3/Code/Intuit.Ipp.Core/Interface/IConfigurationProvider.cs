﻿////*********************************************************
// <copyright file="IConfigurationProvider.cs" company="Intuit">
/*******************************************************************************
 * Copyright 2016 Intuit
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *******************************************************************************/
// <summary>This file contains SdkException.</summary>
// <summary>This file contains interface for configuration reader.</summary>
////*********************************************************

namespace Intuit.Ipp.Core
{
    using Intuit.Ipp.Core.Configuration;

    /// <summary>
    /// Interface, that can provide <see cref="IppConfiguration"/> from file for example.
    /// <seealso cref="MemoryConfigurationProvider"/>
    /// </summary>
    public interface IConfigurationProvider
    {
        /// <summary>
        /// Returns the <see cref="IppConfiguration"/> object.
        /// </summary>
        /// <returns>The custom config object.</returns>
        IppConfiguration GetConfiguration();
    }
}
