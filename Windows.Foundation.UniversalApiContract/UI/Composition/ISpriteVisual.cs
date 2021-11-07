// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ISpriteVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(148919681, 6865, 20375, 151, 87, 64, 45, 118, 228, 35, 59)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpriteVisual))]
  [WebHostHidden]
  internal interface ISpriteVisual
  {
    CompositionBrush Brush { get; set; }
  }
}
