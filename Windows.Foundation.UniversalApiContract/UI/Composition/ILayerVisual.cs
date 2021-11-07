// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ILayerVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (LayerVisual))]
  [Guid(2944678277, 1092, 18567, 142, 131, 180, 11, 37, 63, 130, 44)]
  internal interface ILayerVisual
  {
    CompositionEffectBrush Effect { get; set; }
  }
}
