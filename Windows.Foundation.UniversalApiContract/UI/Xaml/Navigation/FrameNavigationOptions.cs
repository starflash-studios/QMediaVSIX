// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.FrameNavigationOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  /// <summary>Represents options for a frame navigation, including whether it is recorded in the navigation stack and what transition animation is used.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IFrameNavigationOptionsFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public class FrameNavigationOptions : IFrameNavigationOptions
  {
    /// <summary>Initializes a new instance of the FrameNavigationOptions class.</summary>
    [MethodImpl]
    public extern FrameNavigationOptions();

    /// <summary>Gets or sets a value that indicates whether navigation is recorded in the Frame's ForwardStack or BackStack.</summary>
    /// <returns>**true** if navigation is recorded in the Frame's ForwardStack or BackStack; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsNavigationStackEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the animated transition associated with the navigation.</summary>
    /// <returns>Info about the animated transition.</returns>
    public extern NavigationTransitionInfo TransitionInfoOverride { [MethodImpl] get; [MethodImpl] set; }
  }
}
