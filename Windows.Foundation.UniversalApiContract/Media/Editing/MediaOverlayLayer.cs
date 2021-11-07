// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.MediaOverlayLayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Editing
{
  /// <summary>Represents a layer of a media overlay.</summary>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [GCPressure(amount = GCPressureAmount.High)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IMediaOverlayLayerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaOverlayLayer : IMediaOverlayLayer
  {
    /// <summary>Initializes a new instance of the MediaOverlayLayer class.</summary>
    /// <param name="compositorDefinition">The definition of the custom compositor associated with the media overlay layer.  This is </param>
    [MethodImpl]
    public extern MediaOverlayLayer(IVideoCompositorDefinition compositorDefinition);

    /// <summary>Initializes a new instance of the MediaOverlayLayer class.</summary>
    [MethodImpl]
    public extern MediaOverlayLayer();

    /// <summary>Creates a MediaOverlayLayer object that is identical to this instance.</summary>
    /// <returns>A MediaOverlayLayer object that is a copy of this instance.</returns>
    [MethodImpl]
    public extern MediaOverlayLayer Clone();

    /// <summary>Gets the list of overlays for this media overlay layer.</summary>
    /// <returns>The list of overlays for this media overlay layer.</returns>
    public extern IVector<MediaOverlay> Overlays { [MethodImpl] get; }

    /// <summary>Gets the definition of the custom compositor associated with the media overlay layer, if there is one.</summary>
    /// <returns>The definition of the custom compositor associated with the media overlay layer.</returns>
    public extern IVideoCompositorDefinition CustomCompositorDefinition { [MethodImpl] get; }
  }
}
