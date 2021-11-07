// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedVideoCaptureDeviceController5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(860957463, 47563, 18979, 184, 117, 249, 234, 171, 83, 84, 146)]
  [ExclusiveTo(typeof (VideoDeviceController))]
  internal interface IAdvancedVideoCaptureDeviceController5
  {
    string Id { get; }

    VideoDeviceControllerGetDevicePropertyResult GetDevicePropertyById(
      string propertyId,
      IReference<uint> maxPropertyValueSize);

    VideoDeviceControllerSetDevicePropertyStatus SetDevicePropertyById(
      string propertyId,
      [Variant] object propertyValue);

    VideoDeviceControllerGetDevicePropertyResult GetDevicePropertyByExtendedId(
      byte[] extendedPropertyId,
      IReference<uint> maxPropertyValueSize);

    VideoDeviceControllerSetDevicePropertyStatus SetDevicePropertyByExtendedId(
      byte[] extendedPropertyId,
      byte[] propertyValue);
  }
}
