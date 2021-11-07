// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReliableWriteTransaction2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(1360083335, 61202, 17967, 159, 178, 161, 164, 58, 103, 148, 22)]
  [ExclusiveTo(typeof (GattReliableWriteTransaction))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattReliableWriteTransaction2
  {
    [RemoteAsync]
    IAsyncOperation<GattWriteResult> CommitWithResultAsync();
  }
}
