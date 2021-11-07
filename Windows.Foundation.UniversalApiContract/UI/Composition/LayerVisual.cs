// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.LayerVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A ContainerVisual whose children are flattened into a single layer.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  public sealed class LayerVisual : ContainerVisual, ILayerVisual, ILayerVisual2
  {
    /// <summary>The effect to be applied to the flattened representation of the children of a LayerVisual.</summary>
    /// <returns>The effect to be applied to the flattened representation of the children of a LayerVisual.</returns>
    public extern CompositionEffectBrush Effect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The shadow to be applied to the flattened representation of the children of a LayerVisual.</summary>
    /// <returns>
    /// </returns>
    public extern CompositionShadow Shadow { [MethodImpl] get; [MethodImpl] set; }
  }
}
