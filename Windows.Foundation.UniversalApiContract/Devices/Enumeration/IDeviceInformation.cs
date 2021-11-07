// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(2879454101, 17304, 18589, 142, 68, 230, 19, 9, 39, 1, 31)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceInformation))]
  internal interface IDeviceInformation
  {
    string Id { get; }

    string Name { get; }

    bool IsEnabled { get; }

    bool IsDefault { get; }

    EnclosureLocation EnclosureLocation { get; }

    IMapView<string, object> Properties { [return: HasVariant] get; }

    void Update(DeviceInformationUpdate updateInfo);

    [RemoteAsync]
    IAsyncOperation<DeviceThumbnail> GetThumbnailAsync();

    [RemoteAsync]
    IAsyncOperation<DeviceThumbnail> GetGlyphThumbnailAsync();
  }
}
