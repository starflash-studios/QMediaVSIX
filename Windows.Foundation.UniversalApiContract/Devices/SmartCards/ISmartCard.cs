// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCard
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (SmartCard))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(460425329, 25652, 17396, 181, 90, 106, 41, 98, 56, 112, 170)]
  internal interface ISmartCard
  {
    SmartCardReader Reader { get; }

    [RemoteAsync]
    IAsyncOperation<SmartCardStatus> GetStatusAsync();

    [RemoteAsync]
    IAsyncOperation<IBuffer> GetAnswerToResetAsync();
  }
}
