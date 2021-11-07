// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionRadialGradientBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (CompositionRadialGradientBrush))]
  [Guid(1027297477, 58362, 19682, 185, 252, 62, 225, 37, 97, 120, 143)]
  internal interface ICompositionRadialGradientBrush
  {
    Vector2 EllipseCenter { get; set; }

    Vector2 EllipseRadius { get; set; }

    Vector2 GradientOriginOffset { get; set; }
  }
}
