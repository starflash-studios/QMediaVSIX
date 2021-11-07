// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Visual))]
  [Guid(293478445, 43097, 19593, 135, 59, 194, 170, 86, 103, 136, 227)]
  internal interface IVisual
  {
    Vector2 AnchorPoint { get; set; }

    CompositionBackfaceVisibility BackfaceVisibility { get; set; }

    CompositionBorderMode BorderMode { get; set; }

    Vector3 CenterPoint { get; set; }

    CompositionClip Clip { get; set; }

    CompositionCompositeMode CompositeMode { get; set; }

    bool IsVisible { get; set; }

    Vector3 Offset { get; set; }

    float Opacity { get; set; }

    Quaternion Orientation { get; set; }

    ContainerVisual Parent { get; }

    float RotationAngle { get; set; }

    float RotationAngleInDegrees { get; set; }

    Vector3 RotationAxis { get; set; }

    Vector3 Scale { get; set; }

    Vector2 Size { get; set; }

    Matrix4x4 TransformMatrix { get; set; }
  }
}
