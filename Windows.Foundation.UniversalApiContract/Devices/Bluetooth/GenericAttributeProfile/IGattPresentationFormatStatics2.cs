// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattPresentationFormatStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2848069395, 47151, 17246, 182, 52, 33, 253, 133, 164, 60, 7)]
  [ExclusiveTo(typeof (GattPresentationFormat))]
  internal interface IGattPresentationFormatStatics2 : IGattPresentationFormatStatics
  {
    GattPresentationFormat FromParts(
      byte formatType,
      int exponent,
      ushort unit,
      byte namespaceId,
      ushort description);
  }
}
