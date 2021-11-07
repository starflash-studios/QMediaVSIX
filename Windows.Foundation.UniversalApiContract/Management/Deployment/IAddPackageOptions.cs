// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IAddPackageOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(97443864, 63119, 16939, 149, 164, 102, 103, 158, 199, 127, 192)]
  [ExclusiveTo(typeof (AddPackageOptions))]
  internal interface IAddPackageOptions
  {
    IVector<Uri> DependencyPackageUris { get; }

    PackageVolume TargetVolume { get; set; }

    IVector<string> OptionalPackageFamilyNames { get; }

    IVector<Uri> OptionalPackageUris { get; }

    IVector<Uri> RelatedPackageUris { get; }

    Uri ExternalLocationUri { get; set; }

    StubPackageOption StubPackageOption { get; set; }

    bool DeveloperMode { get; set; }

    bool ForceAppShutdown { get; set; }

    bool ForceTargetAppShutdown { get; set; }

    bool ForceUpdateFromAnyVersion { get; set; }

    bool InstallAllResources { get; set; }

    bool RequiredContentGroupOnly { get; set; }

    bool RetainFilesOnFailure { get; set; }

    bool StageInPlace { get; set; }

    bool AllowUnsigned { get; set; }

    bool DeferRegistrationWhenPackagesAreInUse { get; set; }
  }
}
