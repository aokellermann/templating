﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable

using System.CommandLine;

namespace Microsoft.TemplateEngine.Cli.Commands
{
    internal interface ITabularOutputCommand
    {
        internal Option<bool> ColumnsAllOption { get; }

        internal Option<IReadOnlyList<string>> ColumnsOption { get; }
    }

    internal interface ITabularOutputArgs
    {
        internal bool DisplayAllColumns { get; }

        internal IReadOnlyList<string>? ColumnsToDisplay { get; }
    }
}
