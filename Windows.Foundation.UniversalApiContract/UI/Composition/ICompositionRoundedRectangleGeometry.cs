// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionRoundedRectangleGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionRoundedRectangleGeometry))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [Guid(2272315426, 7504, 19339, 176, 19, 124, 154, 14, 70, 147, 95)]
  internal interface ICompositionRoundedRectangleGeometry
  {
    Vector2 CornerRadius { get; set; }

    Vector2 Offset { get; set; }

    Vector2 Size { get; set; }
  }
}
