// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialReceiverApp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ExclusiveTo(typeof (DialReceiverApp))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(4248730711, 20549, 18190, 179, 4, 77, 217, 177, 62, 125, 17)]
  internal interface IDialReceiverApp
  {
    [RemoteAsync]
    IAsyncOperation<IMap<string, string>> GetAdditionalDataAsync();

    [RemoteAsync]
    IAsyncAction SetAdditionalDataAsync(
      IIterable<IKeyValuePair<string, string>> additionalData);
  }
}
