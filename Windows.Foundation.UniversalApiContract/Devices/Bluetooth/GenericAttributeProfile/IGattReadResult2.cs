// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReadResult2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(2702135456, 64323, 18607, 186, 170, 99, 138, 92, 99, 41, 254)]
  [ExclusiveTo(typeof (GattReadResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattReadResult2
  {
    IReference<byte> ProtocolError { get; }
  }
}
