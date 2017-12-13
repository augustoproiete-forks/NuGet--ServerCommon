﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace NuGet.Services.Validation
{
    /// <summary>
    /// The codes for <see cref="IValidationIssue"/>.
    /// </summary>
    public enum ValidationIssueCode
    {
        /// <summary>
        /// An unknown issue has occurred.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Signed packages are blocked.
        /// </summary>
        PackageIsSigned = 1,
    }
}