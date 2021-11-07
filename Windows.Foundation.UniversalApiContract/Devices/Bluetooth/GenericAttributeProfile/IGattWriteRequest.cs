// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattWriteRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(2931206637, 56879, 20418, 169, 168, 148, 234, 120, 68, 241, 61)]
  [ExclusiveTo(typeof (GattWriteRequest))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattWriteRequest
  {
    IBuffer Value { get; }

    uint Offset { get; }

    GattWriteOption Option { get; }

    GattRequestState State { get; }

    event TypedEventHandler<GattWriteRequest, GattRequestStateChangedEventArgs> StateChanged;

    void Respond();

    void RespondWithProtocolError(byte protocolError);
  }
}
