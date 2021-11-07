// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IConnectedAnimation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ConnectedAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1563397724, 22603, 19933, 182, 104, 151, 56, 145, 67, 20, 89)]
  [WebHostHidden]
  internal interface IConnectedAnimation2
  {
    bool IsScaleAnimationEnabled { get; set; }

    [Overload("TryStartWithCoordinatedElements")]
    bool TryStart(UIElement destination, IIterable<UIElement> coordinatedElements);

    void SetAnimationComponent(
      ConnectedAnimationComponent component,
      ICompositionAnimationBase animation);
  }
}
