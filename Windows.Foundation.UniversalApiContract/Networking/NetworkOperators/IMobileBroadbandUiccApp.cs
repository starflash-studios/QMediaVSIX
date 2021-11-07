// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandUiccApp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandUiccApp))]
  [Guid(1293354326, 39073, 17373, 178, 236, 80, 201, 12, 242, 72, 223)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandUiccApp
  {
    IBuffer Id { get; }

    UiccAppKind Kind { get; }

    IAsyncOperation<MobileBroadbandUiccAppRecordDetailsResult> GetRecordDetailsAsync(
      IIterable<uint> uiccFilePath);

    IAsyncOperation<MobileBroadbandUiccAppReadRecordResult> ReadRecordAsync(
      IIterable<uint> uiccFilePath,
      int recordIndex);
  }
}
