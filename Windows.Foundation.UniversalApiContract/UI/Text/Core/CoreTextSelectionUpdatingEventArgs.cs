// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextSelectionUpdatingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>Provides data for the SelectionUpdating event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CoreTextSelectionUpdatingEventArgs : ICoreTextSelectionUpdatingEventArgs
  {
    /// <summary>Gets a value that indicates the range of text that the text input server indicates should be selected. The server populates this property before raising the event.</summary>
    /// <returns>The range of text that the server indicates should be selected.</returns>
    public extern CoreTextRange Selection { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates the result of handling the SelectionUpdating event. The default value is **Succeeded** but if you can't action the operation as the text input server expects then before returning from the event handler set the property to the appropriate value to indicate what has happened.</summary>
    /// <returns>The result of handling the SelectionUpdating event. The default is **Succeeded**.</returns>
    public extern CoreTextSelectionUpdatingResult Result { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the selection update operation is canceled.</summary>
    /// <returns>**true** if the selection update operation is canceled; otherwise, **false**.</returns>
    public extern bool IsCanceled { [MethodImpl] get; }

    /// <summary>Requests that the selection update operation be delayed. Call this method if your text input control is hosted on a worker thread rather than on the UI thread.</summary>
    /// <returns>A Deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
