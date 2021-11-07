// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionVisualSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (CompositionVisualSurface))]
  [WebHostHidden]
  [Guid(2988759043, 20334, 19007, 140, 174, 61, 193, 205, 167, 79, 198)]
  internal interface ICompositionVisualSurface
  {
    Visual SourceVisual { get; set; }

    Vector2 SourceOffset { get; set; }

    Vector2 SourceSize { get; set; }
  }
}
