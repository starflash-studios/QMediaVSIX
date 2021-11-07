// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionProjectedShadowCaster
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(2983711782, 7734, 23138, 190, 86, 161, 97, 18, 253, 209, 72)]
  [ExclusiveTo(typeof (CompositionProjectedShadowCaster))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  internal interface ICompositionProjectedShadowCaster
  {
    CompositionBrush Brush { get; set; }

    Visual CastingVisual { get; set; }
  }
}
