// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Represents the state of the package.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PackageState
  {
    /// <summary>The package is usable.</summary>
    Normal,
    /// <summary>The license of the package is not valid.</summary>
    LicenseInvalid,
    /// <summary>The package payload was modified by an unknown source.</summary>
    Modified,
    /// <summary>The package payload was tampered with intentionally.</summary>
    Tampered,
  }
}
