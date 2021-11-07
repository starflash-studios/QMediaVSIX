// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.AddPackageByAppInstallerOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>A subset of DeploymentOptions that are valid for App Installer.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum AddPackageByAppInstallerOptions : uint
  {
    /// <summary>The default behavior is used.</summary>
    None = 0,
    /// <summary>When you set this option, the app is instructed to skip resource applicability checks. This effectively stages or registers all resource packages that a user passes in to the command, which forces applicability for all packages contained in a bundle. If a user passes in a bundle, all contained resource packages will be registered.</summary>
    InstallAllResources = 32, // 0x00000020
    /// <summary>If this package is currently in use, the processes associated with the package are shut down forcibly so that registration can continue.</summary>
    ForceTargetAppShutdown = 64, // 0x00000040
    /// <summary>When you set this option, only the required content group will be staged. An app can be installed as a package with the required content group alone.</summary>
    RequiredContentGroupOnly = 256, // 0x00000100
    /// <summary>Do not download missing referenced packages</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] LimitToExistingPackages = 512, // 0x00000200
  }
}
