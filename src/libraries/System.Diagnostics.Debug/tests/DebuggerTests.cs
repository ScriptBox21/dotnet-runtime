﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace System.Diagnostics.Tests
{
    public class DebuggerTests
    {
        [Fact]
        public void IsAttached()
        {
            // TODO: Implement this when Debugger is properly implemented
            Assert.False(Debugger.IsAttached);
        }

        [Fact]
        public void Launch()
        {
            // TODO: Implement this when Debugger is properly implemented
            Assert.Throws<NotImplementedException>(() => Debugger.Launch());
        }

        [Fact]
        public void Break()
        {
            // TODO: Implement this when Debugger is properly implemented
            Assert.Throws<NotImplementedException>(() => Debugger.Break());
        }
    }
}
