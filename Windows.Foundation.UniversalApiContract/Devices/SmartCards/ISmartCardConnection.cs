// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Guid(2128320794, 43034, 18364, 166, 73, 21, 107, 230, 183, 242, 49)]
  [ExclusiveTo(typeof (SmartCardConnection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmartCardConnection : IClosable
  {
    [RemoteAsync]
    IAsyncOperation<IBuffer> TransmitAsync(IBuffer command);
  }
}
