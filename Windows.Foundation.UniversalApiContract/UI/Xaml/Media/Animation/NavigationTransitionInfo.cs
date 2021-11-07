// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides parameter info for the Frame.Navigate method. Controls how the transition animation runs during the navigation action.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (INavigationTransitionInfoFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class NavigationTransitionInfo : 
    DependencyObject,
    INavigationTransitionInfo,
    INavigationTransitionInfoOverrides
  {
    /// <summary>Initializes a new instance of the NavigationTransitionInfo class.</summary>
    [MethodImpl]
    protected extern NavigationTransitionInfo();

    [MethodImpl]
    extern string INavigationTransitionInfoOverrides.GetNavigationStateCore();

    [MethodImpl]
    extern void INavigationTransitionInfoOverrides.SetNavigationStateCore(
      string navigationState);
  }
}
