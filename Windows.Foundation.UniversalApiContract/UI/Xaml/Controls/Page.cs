// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Page
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents content that a Frame control can navigate to.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPageStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IPageFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class Page : UserControl, IPage, IPageOverrides
  {
    /// <summary>Initializes a new instance of the Page class.</summary>
    [MethodImpl]
    public extern Page();

    /// <summary>Gets the controlling Frame for the Page content.</summary>
    /// <returns>The controlling Frame for the Page content.</returns>
    public extern Frame Frame { [MethodImpl] get; }

    /// <summary>Gets or sets the navigation mode that indicates whether this Page is cached, and the period of time that the cache entry should persist.</summary>
    /// <returns>A value of the enumeration. The default is **Disabled**.</returns>
    public extern NavigationCacheMode NavigationCacheMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a reference to an AppBar displayed at the top of the page, if any.</summary>
    /// <returns>A reference to an AppBar displayed at the top of the page, or **null**.</returns>
    public extern AppBar TopAppBar { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a reference to an AppBar displayed at the bottom of the page, if any.</summary>
    /// <returns>A reference to an AppBar displayed at the bottom of the page, or **null**.</returns>
    public extern AppBar BottomAppBar { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern void IPageOverrides.OnNavigatedFrom(NavigationEventArgs e);

    [MethodImpl]
    extern void IPageOverrides.OnNavigatedTo(NavigationEventArgs e);

    [MethodImpl]
    extern void IPageOverrides.OnNavigatingFrom(NavigatingCancelEventArgs e);

    /// <summary>Identifies the Frame dependency property.</summary>
    /// <returns>The identifier for the Frame dependency property.</returns>
    public static extern DependencyProperty FrameProperty { [MethodImpl] get; }

    /// <summary>Identifies the TopAppBar dependency property.</summary>
    /// <returns>The identifier for the TopAppBar dependency property.</returns>
    public static extern DependencyProperty TopAppBarProperty { [MethodImpl] get; }

    /// <summary>Identifies the BottomAppBar dependency property.</summary>
    /// <returns>The identifier for the BottomAppBar dependency property.</returns>
    public static extern DependencyProperty BottomAppBarProperty { [MethodImpl] get; }
  }
}
