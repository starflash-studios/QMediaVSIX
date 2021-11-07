// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.NavigationThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides page navigation animations.</summary>
  [Static(typeof (INavigationThemeTransitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ContentProperty(Name = "DefaultNavigationTransitionInfo")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NavigationThemeTransition : Transition, INavigationThemeTransition
  {
    /// <summary>Initializes a new instance of the NavigationThemeTransition class.</summary>
    [MethodImpl]
    public extern NavigationThemeTransition();

    /// <summary>Gets or sets the default transition used when navigating between pages.</summary>
    /// <returns>The default transition used when navigating between pages.</returns>
    public extern NavigationTransitionInfo DefaultNavigationTransitionInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the DefaultNavigationTransitionInfo dependency property.</summary>
    /// <returns>Identifier for the DefaultNavigationTransitionInfo dependency property.</returns>
    public static extern DependencyProperty DefaultNavigationTransitionInfoProperty { [MethodImpl] get; }
  }
}
