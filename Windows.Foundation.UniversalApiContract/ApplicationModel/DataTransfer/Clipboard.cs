// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.Clipboard
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Gets and sets information from the clipboard object.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IClipboardStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IClipboardStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class Clipboard
  {
    /// <summary>Gets the list of items currently in the clipboard history.</summary>
    /// <returns>An asynchronous operation that, on successful completion, returns a ClipboardHistoryItemsResult object that contains the items currently in the clipboard history.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ClipboardHistoryItemsResult> GetHistoryItemsAsync();

    /// <summary>Clears the clipboard history.</summary>
    /// <returns>True if the clear history operation was successful; otherwise, false.</returns>
    [MethodImpl]
    public static extern bool ClearHistory();

    /// <summary>Deletes the specified item from the clipboard history.</summary>
    /// <param name="item">The item to remove from the clipboard history.</param>
    /// <returns>True if the item was successfully removed from the clipboard history; otherwise, false.</returns>
    [MethodImpl]
    public static extern bool DeleteItemFromHistory(ClipboardHistoryItem item);

    /// <summary>Sets an item in the clipboard history as the current content for the clipboard.</summary>
    /// <param name="item">The item in the clipboard history to set as the current content for the clipboard.</param>
    /// <returns>The status of the operation.</returns>
    [MethodImpl]
    public static extern SetHistoryItemAsContentStatus SetHistoryItemAsContent(
      ClipboardHistoryItem item);

    /// <summary>Indicates whether clipboard history (that is, the ability to save multiple items to the clipboard) is enabled for the current user.</summary>
    /// <returns>True if clipboard history is enabled for the current user; otherwise, false.</returns>
    [MethodImpl]
    public static extern bool IsHistoryEnabled();

    /// <summary>Indicates whether clipboard data is set to sync across devices for the current user.</summary>
    /// <returns>True if clipboard data is set to sync across devices for the current user; otherwise, false.</returns>
    [MethodImpl]
    public static extern bool IsRoamingEnabled();

    /// <summary>Sets the content that is stored in the clipboard object with options for the content.</summary>
    /// <param name="content">Contains the content to store in the clipboard. If null, the clipboard is emptied.</param>
    /// <param name="options">An object that specifies options for the clipboard content, such as whether the content is allowed in the clipboard history and whether it will be synced to other devices.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern bool SetContentWithOptions(
      DataPackage content,
      ClipboardContentOptions options);

    /// <summary>Occurs when a new item is added to the clipboard history.</summary>
    public static extern event EventHandler<ClipboardHistoryChangedEventArgs> HistoryChanged;

    /// <summary>Occurs when the OS setting that controls whether clipboard data is set to sync across devices for the current user is changed.</summary>
    public static extern event EventHandler<object> RoamingEnabledChanged;

    /// <summary>Occurs when the OS setting that controls whether clipboard history is enabled for the current user is changed.</summary>
    public static extern event EventHandler<object> HistoryEnabledChanged;

    /// <summary>Gets the current content that is stored in the clipboard object.</summary>
    /// <returns>Contains the content of the Clipboard.</returns>
    [MethodImpl]
    public static extern DataPackageView GetContent();

    /// <summary>Sets the current content that is stored in the clipboard object.</summary>
    /// <param name="content">Contains the content of the clipboard. If **NULL**, the clipboard is emptied.</param>
    [MethodImpl]
    public static extern void SetContent(DataPackage content);

    /// <summary>Adds the content to the Clipboard and releases the DataPackage object from the source app. This method allows the content to remain available after the application shuts down.</summary>
    [MethodImpl]
    public static extern void Flush();

    /// <summary>Removes all data from the Clipboard.</summary>
    [MethodImpl]
    public static extern void Clear();

    /// <summary>Occurs when the data stored in the Clipboard changes.</summary>
    public static extern event EventHandler<object> ContentChanged;
  }
}
