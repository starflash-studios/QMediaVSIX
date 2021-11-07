// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageWithMetadata
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (Package))]
  [Guid(2509543296, 7657, 16626, 180, 82, 13, 233, 241, 145, 0, 18)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPackageWithMetadata
  {
    DateTime InstallDate { get; }

    string GetThumbnailToken();

    [Deprecated("Launch may be altered or unavailable for releases after Windows 8.1. Instead, for SmartCardTrigger scenarios use SmartCardTriggerDetails.TryLaunchSelfAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void Launch(string parameters);
  }
}
