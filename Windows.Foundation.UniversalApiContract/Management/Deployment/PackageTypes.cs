// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageTypes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Defines the types of packages to be included in the result set of a query.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum PackageTypes : uint
  {
    /// <summary>Default inventorying behavior.</summary>
    None = 0,
    /// <summary>Include the main packages when you enumerate the package repository.</summary>
    Main = 1,
    /// <summary>Include the framework packages when you enumerate the package repository.</summary>
    Framework = 2,
    /// <summary>Include the resource packages when you enumerate the package repository.</summary>
    Resource = 4,
    /// <summary>Include the bundle packages when you enumerate the package repository.</summary>
    Bundle = 8,
    /// <summary>Include the XAP packages when you enumerate the package repository.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Xap = 16, // 0x00000010
    /// <summary>Include the optional packages when you enumerate the package repository.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Optional = 32, // 0x00000020
    /// <summary>Include all packages when you enumerate the package repository.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] All = 4294967295, // 0xFFFFFFFF
  }
}
