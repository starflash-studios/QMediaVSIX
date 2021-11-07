﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionShape
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (CompositionShape))]
  [Guid(3028083447, 39560, 17092, 158, 135, 46, 80, 12, 168, 104, 140)]
  internal interface ICompositionShape
  {
    Vector2 CenterPoint { get; set; }

    Vector2 Offset { get; set; }

    float RotationAngle { get; set; }

    float RotationAngleInDegrees { get; set; }

    Vector2 Scale { get; set; }

    Matrix3x2 TransformMatrix { get; set; }
  }
}