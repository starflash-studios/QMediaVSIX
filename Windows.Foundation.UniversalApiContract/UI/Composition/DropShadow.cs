// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.DropShadow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>A drop shadow cast by a SpriteVisual or LayerVisual.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public sealed class DropShadow : CompositionShadow, IDropShadow, IDropShadow2
  {
    /// <summary>The radius of the Gaussian blur used to generate the shadow. Animatable.</summary>
    /// <returns>The radius of the Gaussian blur used to generate the shadow. Defaults to 9.0f. Specifying a value of 0 will result in no blur occurring.</returns>
    public extern float BlurRadius { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The color of the shadow. Animatable.</summary>
    /// <returns>The color of the shadow. Default color is Colors.Black.</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Brush used to specify an opacity mask for the shadow. Defaults to the SpriteVisual's brush. Animatable.</summary>
    /// <returns>Brush used to specify an opacity mask for the shadow. Defaults to the SpriteVisual's brush.</returns>
    public extern CompositionBrush Mask { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Offset of the shadow relative to its SpriteVisual. Animatable.</summary>
    /// <returns>Offset of the shadow relative to its SpriteVisual.</returns>
    public extern Vector3 Offset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The opacity of the shadow. Animatable.</summary>
    /// <returns>The opacity of the shadow.</returns>
    public extern float Opacity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Used to define the shadow masking policy to be used for the shadow.</summary>
    /// <returns>The masking policy to apply to the shadow.</returns>
    public extern CompositionDropShadowSourcePolicy SourcePolicy { [MethodImpl] get; [MethodImpl] set; }
  }
}
