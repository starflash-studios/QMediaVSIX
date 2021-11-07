// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.IFrameNavigationOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  [WebHostHidden]
  [Guid(3040455978, 40887, 21002, 143, 65, 87, 165, 12, 89, 207, 146)]
  [ExclusiveTo(typeof (FrameNavigationOptions))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IFrameNavigationOptions
  {
    bool IsNavigationStackEnabled { get; set; }

    NavigationTransitionInfo TransitionInfoOverride { get; set; }
  }
}
