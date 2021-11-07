// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ILicenseInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (LicenseInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2394414128, 61808, 20181, 142, 33, 21, 22, 218, 63, 211, 103)]
  internal interface ILicenseInformation
  {
    IMapView<string, ProductLicense> ProductLicenses { get; }

    bool IsActive { get; }

    bool IsTrial { get; }

    DateTime ExpirationDate { get; }

    event LicenseChangedEventHandler LicenseChanged;
  }
}
