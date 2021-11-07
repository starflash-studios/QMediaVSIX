// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement9
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI.Composition;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (UIElement))]
  [WebHostHidden]
  [Guid(3030402934, 20104, 20682, 143, 43, 8, 148, 13, 108, 95, 148)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IUIElement9
  {
    bool CanBeScrollAnchor { get; set; }

    ScalarTransition OpacityTransition { get; set; }

    Vector3 Translation { get; set; }

    Vector3Transition TranslationTransition { get; set; }

    float Rotation { get; set; }

    ScalarTransition RotationTransition { get; set; }

    Vector3 Scale { get; set; }

    Vector3Transition ScaleTransition { get; set; }

    Matrix4x4 TransformMatrix { get; set; }

    Vector3 CenterPoint { get; set; }

    Vector3 RotationAxis { get; set; }

    void StartAnimation(ICompositionAnimationBase animation);

    void StopAnimation(ICompositionAnimationBase animation);
  }
}
