// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReliableWriteTransaction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattReliableWriteTransaction))]
  [Guid(1671851783, 6890, 19532, 165, 15, 151, 186, 228, 116, 179, 72)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGattReliableWriteTransaction
  {
    void WriteValue(GattCharacteristic characteristic, IBuffer value);

    [RemoteAsync]
    IAsyncOperation<GattCommunicationStatus> CommitAsync();
  }
}
