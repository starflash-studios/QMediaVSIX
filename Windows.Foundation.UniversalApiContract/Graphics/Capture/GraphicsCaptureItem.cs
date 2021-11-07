// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.GraphicsCaptureItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Composition;

namespace Windows.Graphics.Capture
{
  /// <summary>The target of the capture, chosen with the picker control.</summary>
  [Static(typeof (IGraphicsCaptureItemStatics2), 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGraphicsCaptureItemStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  public sealed class GraphicsCaptureItem : IGraphicsCaptureItem
  {
    /// <summary>The display name of the target of the capture (for example, the application title).</summary>
    /// <returns>The display name of the target of the capture (for example, the application title).</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>The size of the target of the capture.</summary>
    /// <returns>The size of the target of the capture.</returns>
    public extern SizeInt32 Size { [MethodImpl] get; }

    /// <summary>An event raised when the target of the capture has been closed.</summary>
    public extern event TypedEventHandler<GraphicsCaptureItem, object> Closed;

    [MethodImpl]
    public static extern GraphicsCaptureItem TryCreateFromWindowId(
      WindowId windowId);

    [MethodImpl]
    public static extern GraphicsCaptureItem TryCreateFromDisplayId(
      DisplayId displayId);

    /// <summary>Constructs a GraphicsCaptureItem that represents the given Visual.</summary>
    /// <param name="visual">The **Visual** with which to construct the **GraphicsCaptureItem**.</param>
    /// <returns>A **GraphicsCaptureItem** that represents the given **Visual**.</returns>
    [MethodImpl]
    public static extern GraphicsCaptureItem CreateFromVisual(Visual visual);
  }
}
