// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Provides info about the status of a package.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PackageStatus : uint
  {
    /// <summary>The package is usable.</summary>
    OK = 0,
    /// <summary>The license of the package is not valid.</summary>
    LicenseIssue = 1,
    /// <summary>The package payload was modified by an unknown source.</summary>
    Modified = 2,
    /// <summary>The package payload was tampered with intentionally.</summary>
    Tampered = 4,
    /// <summary>The package is not available for use. It can still be serviced.</summary>
    Disabled = 8,
  }
}
