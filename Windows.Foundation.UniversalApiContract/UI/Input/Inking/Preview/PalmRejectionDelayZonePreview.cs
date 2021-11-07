// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Preview.PalmRejectionDelayZonePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Input.Inking.Preview
{
  /// <summary>Provides functionality to support palm rejection around an inking region.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Static(typeof (IPalmRejectionDelayZonePreviewStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PalmRejectionDelayZonePreview : IPalmRejectionDelayZonePreview, IClosable
  {
    [MethodImpl]
    public extern void Close();

    /// <summary>Creates a palm rejection region based on the specified inking panel.</summary>
    /// <param name="inputPanelVisual">The visual object associated with the inking panel.</param>
    /// <param name="inputPanelRect">The region where palm rejection is to be enabled, relative to the coordinate space of the *inputPanelVisual*.</param>
    /// <returns>Returns the palm rejection region.</returns>
    [Overload("CreateForVisual")]
    [MethodImpl]
    public static extern PalmRejectionDelayZonePreview CreateForVisual(
      Visual inputPanelVisual,
      Rect inputPanelRect);

    /// <summary>Creates a palm rejection region based on the specified inking panel and viewport.</summary>
    /// <param name="inputPanelVisual">The visual object associated with the inking panel.</param>
    /// <param name="inputPanelRect">The region where palm rejection is to be enabled, relative to the coordinate space of the *inputPanelVisual*.</param>
    /// <param name="viewportVisual">The visual object associated with the viewport within which *inputPanelVisual* is located.</param>
    /// <param name="viewportRect">The viewport that contains the region where palm rejection is to be enabled, relative to the coordinate space of the *viewportVisual*.</param>
    /// <returns>Returns a PalmRejectionDelayZonePreview object.</returns>
    [Overload("CreateForVisualWithViewportClip")]
    [MethodImpl]
    public static extern PalmRejectionDelayZonePreview CreateForVisual(
      Visual inputPanelVisual,
      Rect inputPanelRect,
      Visual viewportVisual,
      Rect viewportRect);
  }
}
