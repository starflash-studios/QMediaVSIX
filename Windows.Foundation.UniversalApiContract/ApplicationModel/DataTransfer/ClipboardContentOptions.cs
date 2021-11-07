// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ClipboardContentOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Specifies options for using the SetContentWithOptions method to set content in the clipboard.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Activatable(458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class ClipboardContentOptions : IClipboardContentOptions
  {
    /// <summary>Creates a new instance of the ClipboardContentOptions class.</summary>
    [MethodImpl]
    public extern ClipboardContentOptions();

    /// <summary>Gets or sets a value that indicates whether the new content being added to the clipboard can be synced to other devices.</summary>
    /// <returns>True if the new content being added to the clipboard can be synced to other devices; otherwise, false.</returns>
    public extern bool IsRoamable { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the new content being added to the clipboard is allowed in the clipboard history.</summary>
    /// <returns>True if the new content being added to the clipboard is allowed in the clipboard history; otherwise, false.</returns>
    public extern bool IsAllowedInHistory { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of data formats that can be synced to other devices for the content being added to the clipboard.</summary>
    /// <returns>The list of data formats that can be synced to other devices for the content being added to the clipboard. We recommend that you add data formats to this list by using the static properties of the StandardDataFormats class.</returns>
    public extern IVector<string> RoamingFormats { [MethodImpl] get; }

    /// <summary>Gets the list of data formats supported in the clipboard history for the content being added to the clipboard.</summary>
    /// <returns>The list of data formats supported in the clipboard history for the content being added to the clipboard. We recommend that you add data formats to this list by using the static properties of the StandardDataFormats class.</returns>
    public extern IVector<string> HistoryFormats { [MethodImpl] get; }
  }
}
