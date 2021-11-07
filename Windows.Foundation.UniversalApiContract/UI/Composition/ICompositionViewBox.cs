// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionViewBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (CompositionViewBox))]
  [Guid(3024142087, 1679, 17719, 132, 198, 78, 203, 224, 25, 225, 244)]
  [WebHostHidden]
  internal interface ICompositionViewBox
  {
    float HorizontalAlignmentRatio { get; set; }

    Vector2 Offset { get; set; }

    Vector2 Size { get; set; }

    CompositionStretch Stretch { get; set; }

    float VerticalAlignmentRatio { get; set; }
  }
}
