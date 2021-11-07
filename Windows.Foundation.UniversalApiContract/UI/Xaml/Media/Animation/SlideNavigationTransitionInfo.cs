// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides the parameters for a slide navigation transition.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISlideNavigationTransitionInfoStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SlideNavigationTransitionInfo : 
    NavigationTransitionInfo,
    ISlideNavigationTransitionInfo,
    ISlideNavigationTransitionInfo2
  {
    /// <summary>Initializes a new instance of the **SlideNavigationTransitionInfo** class.</summary>
    [MethodImpl]
    public extern SlideNavigationTransitionInfo();

    /// <summary>Gets or sets the type of animation effect to play during the slide transition.</summary>
    /// <returns>The type of animation effect to play during the slide transition.</returns>
    public extern SlideNavigationTransitionEffect Effect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Effect dependency property.</summary>
    /// <returns>The identifier for the Effect dependency property.</returns>
    public static extern DependencyProperty EffectProperty { [MethodImpl] get; }
  }
}
