// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IConnectedAnimationService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(476607945, 6587, 19783, 185, 170, 102, 200, 2, 220, 185, 255)]
  [ExclusiveTo(typeof (ConnectedAnimationService))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IConnectedAnimationService
  {
    TimeSpan DefaultDuration { get; set; }

    CompositionEasingFunction DefaultEasingFunction { get; set; }

    ConnectedAnimation PrepareToAnimate(string key, UIElement source);

    ConnectedAnimation GetAnimation(string key);
  }
}
