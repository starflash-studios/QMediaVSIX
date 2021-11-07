// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDescriptor2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2404793657, 54832, 16492, 186, 17, 16, 205, 209, 107, 14, 94)]
  [ExclusiveTo(typeof (GattDescriptor))]
  internal interface IGattDescriptor2
  {
    [RemoteAsync]
    IAsyncOperation<GattWriteResult> WriteValueWithResultAsync(
      IBuffer value);
  }
}
