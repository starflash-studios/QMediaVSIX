// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICubicBezierEasingFunction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(842335846, 49640, 17657, 150, 184, 201, 138, 207, 10, 230, 152)]
  [ExclusiveTo(typeof (CubicBezierEasingFunction))]
  internal interface ICubicBezierEasingFunction
  {
    Vector2 ControlPoint1 { get; }

    Vector2 ControlPoint2 { get; }
  }
}
