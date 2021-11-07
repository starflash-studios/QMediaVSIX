// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.RemovalOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Values that modify the removal of a package.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum RemovalOptions : uint
  {
    /// <summary>No removal options are specified. This is the default deployment behavior.</summary>
    None = 0,
    /// <summary>Don't remove any application data when the package is removed. This can only apply to packages that were deployed with the DeploymentOptions.DevelopmentMode value. If you specify **PreserveApplicationData** on an incompatible package, PackageManager.RemovePackageAsync(String, RemovalOptions) returns **E_INVALIDARG**.</summary>
    PreserveApplicationData = 4096, // 0x00001000
    /// <summary>Don't remove the roamable portion of the app's data when the package is removed. This value is not supported with the **PreserveApplicationData** and **RemoveForAllUsers** fields. This field is useful in virtual desktop scenarios when additional work needs to be performed to enable the portable part of the app's state to be roamed between remote servers so that a user's virtual desktop session can be logged onto different servers without loss of app state.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] PreserveRoamableApplicationData = 128, // 0x00000080
    /// <summary>Removes a package for all users on the device.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] RemoveForAllUsers = 524288, // 0x00080000
  }
}
