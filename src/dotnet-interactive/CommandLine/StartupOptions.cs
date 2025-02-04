// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using Microsoft.DotNet.Interactive.Http;

namespace Microsoft.DotNet.Interactive.App.CommandLine;

public class StartupOptions
{
    public StartupOptions(
        DirectoryInfo logPath = null,
        bool verbose = false,
        HttpPortRange httpPortRange = null,
        HttpPort httpPort = null,
        Uri kernelHost = null,
        bool preview = false,
        DirectoryInfo workingDir = null)
    {
        LogPath = logPath;
        Verbose = verbose;
        HttpPortRange = httpPortRange;
        HttpPort = httpPort;
        KernelHost = kernelHost;
        Preview = preview;
        WorkingDir = workingDir;
    }

    public DirectoryInfo LogPath { get; }

    public bool Verbose { get; }

    public HttpPort HttpPort { get; internal set; }

    public HttpPortRange HttpPortRange { get; internal set; }
        
    public Uri KernelHost { get; }

    public bool Preview { get; }

    public DirectoryInfo WorkingDir { get; internal set; }

    public bool EnableHttpApi => HttpPort is not null || HttpPortRange is not null;
}
