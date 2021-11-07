// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReadRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(4057818421, 27341, 17062, 164, 187, 215, 137, 218, 224, 4, 62)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattReadRequest))]
  internal interface IGattReadRequest
  {
    uint Offset { get; }

    uint Length { get; }

    GattRequestState State { get; }

    event TypedEventHandler<GattReadRequest, GattRequestStateChangedEventArgs> StateChanged;

    void RespondWithValue(IBuffer value);

    void RespondWithProtocolError(byte protocolError);
  }
}
