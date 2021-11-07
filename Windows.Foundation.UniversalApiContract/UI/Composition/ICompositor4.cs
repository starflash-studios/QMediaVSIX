// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositor4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (Compositor))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2923947914, 30992, 17445, 164, 130, 160, 91, 117, 138, 220, 233)]
  internal interface ICompositor4
  {
    [Overload("CreateColorGradientStop")]
    CompositionColorGradientStop CreateColorGradientStop();

    [Overload("CreateColorGradientStopWithOffsetAndColor")]
    CompositionColorGradientStop CreateColorGradientStop(
      float offset,
      Color color);

    CompositionLinearGradientBrush CreateLinearGradientBrush();

    SpringScalarNaturalMotionAnimation CreateSpringScalarAnimation();

    SpringVector2NaturalMotionAnimation CreateSpringVector2Animation();

    SpringVector3NaturalMotionAnimation CreateSpringVector3Animation();
  }
}
