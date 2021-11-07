// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositor6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Compositor))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2050536125, 52936, 20203, 131, 15, 216, 208, 122, 237, 235, 195)]
  internal interface ICompositor6
  {
    [Overload("CreateGeometricClip")]
    CompositionGeometricClip CreateGeometricClip();

    [Overload("CreateGeometricClipWithGeometry")]
    CompositionGeometricClip CreateGeometricClip(
      CompositionGeometry geometry);

    [Overload("CreateRedirectVisual")]
    RedirectVisual CreateRedirectVisual();

    [Overload("CreateRedirectVisualWithSourceVisual")]
    RedirectVisual CreateRedirectVisual(Visual source);

    BooleanKeyFrameAnimation CreateBooleanKeyFrameAnimation();
  }
}
