// -----------------------------------------------------------------------
// <copyright file="RequestLog.cs" company="Microsoft">
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
// <summary>This file contains advanced logger for IPP .Net SDK..</summary>
// -----------------------------------------------------------------------

using System;

namespace Intuit.Ipp.Diagnostics
{
    using System.IO;
    //using Intuit.Ipp.Exception;
    using System;
    using Serilog;
    using Serilog.Core;
    using Serilog.Events;
    using System.Globalization;

    /// <summary>
    /// Contains properties used to indicate whether request and response messages are to be logged.
    /// </summary>
    public class AdvancedLogging : IAdvancedLogger
    {

        /// <summary>
        /// Serilog ILogger
        /// </summary>
        private Serilog.ILogger logger;

        /// <summary>
        /// Initializes a new instance of Advanced logging class        
        /// </summary>
        /// <param name="customLogger"></param>
        public AdvancedLogging(Serilog.ILogger customLogger) 
        {
            logger = customLogger ?? new LoggerConfiguration().MinimumLevel.Verbose().CreateLogger();
            //Logging first info
            logger.Information("Custom Logger is initialized");
        }

        /// <summary>
        /// Logging message from SDK
        /// </summary>
        /// <param name="messageToWrite"></param>
        public void Log(string messageToWrite)
        {
            logger.Write(LogEventLevel.Verbose, messageToWrite);
        }
    }
}
