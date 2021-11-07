// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IClipboardStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (Clipboard))]
  [Guid(3534494570, 53919, 21835, 179, 3, 240, 69, 35, 69, 254, 2)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IClipboardStatics2
  {
    [RemoteAsync]
    IAsyncOperation<ClipboardHistoryItemsResult> GetHistoryItemsAsync();

    bool ClearHistory();

    bool DeleteItemFromHistory(ClipboardHistoryItem item);

    SetHistoryItemAsContentStatus SetHistoryItemAsContent(
      ClipboardHistoryItem item);

    bool IsHistoryEnabled();

    bool IsRoamingEnabled();

    bool SetContentWithOptions(DataPackage content, ClipboardContentOptions options);

    event EventHandler<ClipboardHistoryChangedEventArgs> HistoryChanged;

    event EventHandler<object> RoamingEnabledChanged;

    event EventHandler<object> HistoryEnabledChanged;
  }
}
