// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextFormatUpdatingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;

namespace Windows.UI.Text.Core
{
  /// <summary>Provides data for the FormatUpdating event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CoreTextFormatUpdatingEventArgs : ICoreTextFormatUpdatingEventArgs
  {
    /// <summary>Gets a value that indicates the range of text that the text input server needs to format. The server populates this property before raising the event.</summary>
    /// <returns>The range of text to format.</returns>
    public extern CoreTextRange Range { [MethodImpl] get; }

    /// <summary>Gets a value that represents the text color to be applied to the text range. The text input server populates this property before raising the event.</summary>
    /// <returns>A value that represents the text color to be applied to the text range.</returns>
    public extern IReference<UIElementType> TextColor { [MethodImpl] get; }

    /// <summary>Gets a value that represents the background color to be applied to the text range. The text input server populates this property before raising the event.</summary>
    /// <returns>A value that represents the background color to be applied to the text range.</returns>
    public extern IReference<UIElementType> BackgroundColor { [MethodImpl] get; }

    /// <summary>Gets a value that represents the underline color to be applied to the text range. The text input server populates this property before raising the event.</summary>
    /// <returns>A value that represents the underline color to be applied to the text range.</returns>
    public extern IReference<UIElementType> UnderlineColor { [MethodImpl] get; }

    /// <summary>Gets a value that represents the underline type to be applied to the text range. The text input server populates this property before raising the event.</summary>
    /// <returns>A value that represents the underline type to be applied to the text range.</returns>
    public extern IReference<global::Windows.UI.Text.UnderlineType> UnderlineType { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the reason that the text input server needs to apply formatting to this range of text. The server populates this property before raising the event.</summary>
    /// <returns>A value that indicates the reason that the server needs to apply formatting to this range of text.</returns>
    public extern CoreTextFormatUpdatingReason Reason { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates the result of handling the FormatUpdating event. The default value is **Succeeded** but if you can't action the operation as the text input server expects then before returning from the event handler set the property to the appropriate value to indicate what has happened.</summary>
    /// <returns>The result of handling the FormatUpdating event. The default is **Succeeded**.</returns>
    public extern CoreTextFormatUpdatingResult Result { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the format update operation is canceled.</summary>
    /// <returns>**true** if the format update operation is canceled; otherwise, **false**.</returns>
    public extern bool IsCanceled { [MethodImpl] get; }

    /// <summary>Requests that the format update operation be delayed. Call this method if your text input control is hosted on a worker thread rather than on the UI thread.</summary>
    /// <returns>A Deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
