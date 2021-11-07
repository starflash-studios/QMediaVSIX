// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageUpdateAvailabilityResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (PackageUpdateAvailabilityResult))]
  [Guid(290344969, 6554, 18593, 160, 121, 49, 60, 69, 99, 74, 113)]
  internal interface IPackageUpdateAvailabilityResult
  {
    PackageUpdateAvailability Availability { get; }

    HResult ExtendedError { get; }
  }
}
