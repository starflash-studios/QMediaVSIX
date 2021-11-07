// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageInstallState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Represents the install state of the package.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PackageInstallState
  {
    /// <summary>The package has not been installed.</summary>
    NotInstalled = 0,
    /// <summary>The package has been downloaded.</summary>
    Staged = 1,
    /// <summary>The package is ready for use.</summary>
    Installed = 2,
    /// <summary>The installation of the package has been paused.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] Paused = 6,
  }
}
