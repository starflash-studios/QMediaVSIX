// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionSurfaceBrush2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Guid(3530650837, 25845, 18066, 157, 199, 113, 182, 29, 126, 88, 128)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CompositionSurfaceBrush))]
  [WebHostHidden]
  internal interface ICompositionSurfaceBrush2
  {
    Vector2 AnchorPoint { get; set; }

    Vector2 CenterPoint { get; set; }

    Vector2 Offset { get; set; }

    float RotationAngle { get; set; }

    float RotationAngleInDegrees { get; set; }

    Vector2 Scale { get; set; }

    Matrix3x2 TransformMatrix { get; set; }
  }
}
