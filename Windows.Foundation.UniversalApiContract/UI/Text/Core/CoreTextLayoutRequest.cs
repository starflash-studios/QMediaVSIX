// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextLayoutRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>Represents information about a LayoutRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreTextLayoutRequest : ICoreTextLayoutRequest, ICoreTextLayoutRequest2
  {
    /// <summary>Gets a value that indicates the range of text whose bounding box is being requested by the text input server. The server populates this property before raising the event.</summary>
    /// <returns>The range of text whose bounding box is being requested by the server.</returns>
    public extern CoreTextRange Range { [MethodImpl] get; }

    /// <summary>Gets the screen coordinates of the bounding box for a range of text, or a text input control.</summary>
    /// <returns>An object that represents the layout bounds information requested by the text input server.</returns>
    public extern CoreTextLayoutBounds LayoutBounds { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the layout request operation is canceled.</summary>
    /// <returns>**true** if the layout request operation is canceled; otherwise, **false**.</returns>
    public extern bool IsCanceled { [MethodImpl] get; }

    /// <summary>Requests that the layout request operation be delayed. Call this method if your text input control is hosted on a worker thread rather than on the UI thread.</summary>
    /// <returns>A Deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();

    /// <summary>Gets the coordinates of the bounding box for a range of text, or a text input control, relative to viewport of your application.</summary>
    /// <returns>An object that represents the layout bounds information requested by the text input server. </returns>
    public extern CoreTextLayoutBounds LayoutBoundsVisualPixels { [MethodImpl] get; }
  }
}
