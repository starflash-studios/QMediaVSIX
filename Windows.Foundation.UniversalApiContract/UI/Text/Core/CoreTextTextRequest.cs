// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextTextRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>Represents information about a TextRequested event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CoreTextTextRequest : ICoreTextTextRequest
  {
    /// <summary>Gets a value that indicates the range of text being requested by the text input server. The server populates this property before raising the event.</summary>
    /// <returns>The range of text being requested by the server.</returns>
    public extern CoreTextRange Range { [MethodImpl] get; }

    /// <summary>Gets or sets the text that the text input server is requesting. The application should set the text being requested before returning from the event handler.</summary>
    /// <returns>The text that the server is requesting. The default is null.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the text request operation is canceled.</summary>
    /// <returns>**true** if the text request operation is canceled; otherwise, **false**.</returns>
    public extern bool IsCanceled { [MethodImpl] get; }

    /// <summary>Requests that the text request operation be delayed. Call this method if your text input control is hosted on a worker thread rather than on the UI thread.</summary>
    /// <returns>A Deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
