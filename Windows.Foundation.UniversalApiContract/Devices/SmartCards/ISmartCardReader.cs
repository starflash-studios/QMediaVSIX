// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (SmartCardReader))]
  [Guid(276083936, 21698, 19952, 129, 122, 20, 193, 67, 120, 240, 108)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmartCardReader
  {
    string DeviceId { get; }

    string Name { get; }

    SmartCardReaderKind Kind { get; }

    [RemoteAsync]
    IAsyncOperation<SmartCardReaderStatus> GetStatusAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<SmartCard>> FindAllCardsAsync();

    event TypedEventHandler<SmartCardReader, CardAddedEventArgs> CardAdded;

    event TypedEventHandler<SmartCardReader, CardRemovedEventArgs> CardRemoved;
  }
}
