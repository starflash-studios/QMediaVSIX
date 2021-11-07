// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStoreConfigurationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [ExclusiveTo(typeof (StoreConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1922006976, 34344, 17132, 132, 162, 7, 120, 14, 180, 77, 139)]
  internal interface IStoreConfigurationStatics
  {
    void SetSystemConfiguration(
      string catalogHardwareManufacturerId,
      string catalogStoreContentModifierId,
      DateTime systemConfigurationExpiration,
      string catalogHardwareDescriptor);

    void SetMobileOperatorConfiguration(
      string mobileOperatorId,
      uint appDownloadLimitInMegabytes,
      uint updateDownloadLimitInMegabytes);

    void SetStoreWebAccountId(string webAccountId);

    bool IsStoreWebAccountId(string webAccountId);

    StoreHardwareManufacturerInfo HardwareManufacturerInfo { get; }

    [RemoteAsync]
    IAsyncOperation<IVectorView<StoreSystemFeature>> FilterUnsupportedSystemFeaturesAsync(
      IIterable<StoreSystemFeature> systemFeatures);
  }
}
