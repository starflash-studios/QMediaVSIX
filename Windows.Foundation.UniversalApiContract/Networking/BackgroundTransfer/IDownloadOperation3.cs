// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IDownloadOperation3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (DownloadOperation))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1344746780, 32094, 19164, 184, 211, 223, 92, 96, 49, 185, 204)]
  internal interface IDownloadOperation3
  {
    bool IsRandomAccessRequired { get; set; }

    IRandomAccessStreamReference GetResultRandomAccessStreamReference();

    IVector<BackgroundTransferFileRange> GetDownloadedRanges();

    event TypedEventHandler<DownloadOperation, BackgroundTransferRangesDownloadedEventArgs> RangesDownloaded;

    Uri RequestedUri { set; }

    IVector<WebErrorStatus> RecoverableWebErrorStatuses { get; }

    IReference<WebErrorStatus> CurrentWebErrorStatus { get; }
  }
}
