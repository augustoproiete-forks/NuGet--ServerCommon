﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using NuGet.Services.Validation;
using Xunit;

namespace NuGet.Services
{
    public class ContractsFacts
    {
        [Fact]
        public void ShouldOnlyHaveInterfacesAndEnums()
        {
            // Arrange
            var assembly = typeof(ValidationStatus).Assembly;

            // Act
            var types = assembly.GetTypes();

            // Assert
            Assert.NotEmpty(types);
            foreach (var type in types)
            {
                Assert.True(type.IsEnum || type.IsInterface, $"{type.FullName} must either be an interface or an enum.");
            }
        }
    }
}
