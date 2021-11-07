// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IStagePackageOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [Guid(185666716, 47453, 19542, 189, 54, 109, 101, 104, 0, 208, 107)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (StagePackageOptions))]
  internal interface IStagePackageOptions
  {
    IVector<Uri> DependencyPackageUris { get; }

    PackageVolume TargetVolume { get; set; }

    IVector<string> OptionalPackageFamilyNames { get; }

    IVector<Uri> OptionalPackageUris { get; }

    IVector<Uri> RelatedPackageUris { get; }

    Uri ExternalLocationUri { get; set; }

    StubPackageOption StubPackageOption { get; set; }

    bool DeveloperMode { get; set; }

    bool ForceUpdateFromAnyVersion { get; set; }

    bool InstallAllResources { get; set; }

    bool RequiredContentGroupOnly { get; set; }

    bool StageInPlace { get; set; }

    bool AllowUnsigned { get; set; }
  }
}
