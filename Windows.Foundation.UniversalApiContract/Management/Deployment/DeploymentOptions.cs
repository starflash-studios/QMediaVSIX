// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.DeploymentOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Specifies the package deployment options.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum DeploymentOptions : uint
  {
    /// <summary>The default behavior is used.</summary>
    None = 0,
    /// <summary>If this package, or any package that depends on this package, is currently in use, the processes associated with the package are shut down forcibly so that registration can continue.</summary>
    ForceApplicationShutdown = 1,
    /// <summary>When you set this option, the app is installed in development mode. For info about development mode, see **Remarks**. Use this option to enable key app development scenarios.You can't use this option in conjunction with a bundle package. If you use this option with a bundle package, your call returns ERROR_INSTALL_FAILED.</summary>
    DevelopmentMode = 2,
    /// <summary>When you set this option, the app is instructed to skip resource applicability checks. This effectively stages or registers all resource packages that a user passes in to the command, which forces applicability for all packages contained in a bundle. If a user passes in a bundle, all contained resource packages will be registered. Windows only.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] InstallAllResources = 32, // 0x00000020
    /// <summary>If this package is currently in use, the processes associated with the package are shut down forcibly so that registration can continue.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ForceTargetApplicationShutdown = 64, // 0x00000040
    /// <summary>When you set this option, only the required content group will be staged. An app can be installed as a package with the required content group alone.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] RequiredContentGroupOnly = 256, // 0x00000100
    /// <summary>Force a specific version of a package to be staged/registered, regardless of if a higher version is already staged/registered.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] ForceUpdateFromAnyVersion = 262144, // 0x00040000
    /// <summary>In the case of a failed deployment, do not remove files that have been created on the target machine during the install process.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] RetainFilesOnFailure = 2097152, // 0x00200000
    /// <summary>When you set this option, the package will be staged in place. This field is useful for notifying the system to prepare for app registration in virtual desktop scenarios.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] StageInPlace = 4194304, // 0x00400000
  }
}
