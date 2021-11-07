// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextTextUpdatingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.UI.Text.Core
{
  /// <summary>Provides data for the TextUpdating event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreTextTextUpdatingEventArgs : ICoreTextTextUpdatingEventArgs
  {
    /// <summary>Gets a value that indicates the range of text that the text input server needs to modify. The server populates this property before raising the event.</summary>
    /// <returns>The range of text to modify.</returns>
    public extern CoreTextRange Range { [MethodImpl] get; }

    /// <summary>Gets the text that the text input server is requesting to be set into the modified range. The server populates this property before raising the event.</summary>
    /// <returns>The text that the server is requesting to be set into the modified range.</returns>
    public extern string Text { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the range of text that the text input server indicates should be selected. The server populates this property before raising the event.</summary>
    /// <returns>The range of text that the server indicates should be selected.</returns>
    public extern CoreTextRange NewSelection { [MethodImpl] get; }

    /// <summary>Gets a Language object representing the current input language.</summary>
    /// <returns>An object representing the current input language.</returns>
    public extern Language InputLanguage { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates the result of handling the TextUpdating event. The default value is **Succeeded** but if you can't action the operation as the text input server expects then before returning from the event handler set the property to the appropriate value to indicate what has happened.</summary>
    /// <returns>The result of handling the TextUpdating event. The default is **Succeeded**.</returns>
    public extern CoreTextTextUpdatingResult Result { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the text update operation is canceled.</summary>
    /// <returns>**true** if the text update operation is canceled; otherwise, **false**.</returns>
    public extern bool IsCanceled { [MethodImpl] get; }

    /// <summary>Requests that the text update operation be delayed. Call this method if your text input control is hosted on a worker thread rather than on the UI thread.</summary>
    /// <returns>A Deferral deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
