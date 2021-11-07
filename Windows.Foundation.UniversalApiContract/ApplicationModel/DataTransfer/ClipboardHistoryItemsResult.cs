// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ClipboardHistoryItemsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Provides response data for using the GetHistoryItemsAsync method to get the list of items currently in the clipboard history.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ClipboardHistoryItemsResult : IClipboardHistoryItemsResult
  {
    /// <summary>Gets the return status of the call to the GetHistoryItemsAsync method to get the list of items currently in the clipboard history.</summary>
    /// <returns>The return status of the call to the GetHistoryItemsAsync method.</returns>
    public extern ClipboardHistoryItemsResultStatus Status { [MethodImpl] get; }

    /// <summary>Gets the list of items in the clipboard history.</summary>
    /// <returns>The list of ClipboardHistoryItem objects in the clipboard history.</returns>
    public extern IVectorView<ClipboardHistoryItem> Items { [MethodImpl] get; }
  }
}
