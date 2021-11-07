// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IPointLight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (PointLight))]
  [WebHostHidden]
  [Guid(2978301363, 3162, 19120, 190, 220, 79, 53, 70, 148, 130, 114)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPointLight
  {
    Color Color { get; set; }

    float ConstantAttenuation { get; set; }

    Visual CoordinateSpace { get; set; }

    float LinearAttenuation { get; set; }

    Vector3 Offset { get; set; }

    float QuadraticAttenuation { get; set; }
  }
}
