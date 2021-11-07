// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ISpotLight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SpotLight))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1520427635, 17569, 20373, 164, 34, 143, 165, 17, 107, 219, 68)]
  internal interface ISpotLight
  {
    float ConstantAttenuation { get; set; }

    Visual CoordinateSpace { get; set; }

    Vector3 Direction { get; set; }

    float InnerConeAngle { get; set; }

    float InnerConeAngleInDegrees { get; set; }

    Color InnerConeColor { get; set; }

    float LinearAttenuation { get; set; }

    Vector3 Offset { get; set; }

    float OuterConeAngle { get; set; }

    float OuterConeAngleInDegrees { get; set; }

    Color OuterConeColor { get; set; }

    float QuadraticAttenuation { get; set; }
  }
}
