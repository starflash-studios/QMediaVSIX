// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.PageStackEntry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  /// <summary>Represents an entry in the BackStack or ForwardStack of a Frame.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IPageStackEntryFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPageStackEntryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PageStackEntry : DependencyObject, IPageStackEntry
  {
    [MethodImpl]
    public extern PageStackEntry(
      TypeName sourcePageType,
      object parameter,
      NavigationTransitionInfo navigationTransitionInfo);

    /// <summary>Gets the type of page associated with this navigation entry.</summary>
    /// <returns>The page type of the navigation entry, as a type reference (System.Type for Microsoft .NET, a TypeName helper struct for Visual C++ component extensions (C++/CX)).</returns>
    public extern TypeName SourcePageType { [MethodImpl] get; }

    /// <summary>Gets the navigation parameter associated with this navigation entry.</summary>
    /// <returns>The navigation parameter.</returns>
    public extern object Parameter { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the animated transition associated with the navigation entry.</summary>
    /// <returns>Info about the animated transition.</returns>
    public extern NavigationTransitionInfo NavigationTransitionInfo { [MethodImpl] get; }

    /// <summary>Identifies the SourcePageType dependency property.</summary>
    /// <returns>The identifier for the SourcePageType dependency property.</returns>
    public static extern DependencyProperty SourcePageTypeProperty { [MethodImpl] get; }
  }
}
