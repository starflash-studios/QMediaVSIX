// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.NavigationEventArgs
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
  /// <summary>Provides data for navigation methods and event handlers that cannot cancel the navigation request.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NavigationEventArgs : INavigationEventArgs, INavigationEventArgs2
  {
    /// <summary>Gets the root node of the target page's content.</summary>
    /// <returns>The root node of the target page's content.</returns>
    public extern object Content { [MethodImpl] get; }

    /// <summary>Gets any "Parameter" object passed to the target page for the navigation.</summary>
    /// <returns>An object that potentially passes parameters to the navigation target. May be null.</returns>
    public extern object Parameter { [MethodImpl] get; }

    /// <summary>Gets the data type of the source page.</summary>
    /// <returns>The data type of the source page, represented as *namespace*.*type* or simply *type*.</returns>
    public extern TypeName SourcePageType { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the direction of movement during navigation</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern NavigationMode NavigationMode { [MethodImpl] get; }

    /// <summary>Gets the Uniform Resource Identifier (URI) of the target.</summary>
    /// <returns>A value that represents the Uniform Resource Identifier (URI).</returns>
    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates the animated transition associated with the navigation.</summary>
    /// <returns>Info about the animated transition.</returns>
    public extern NavigationTransitionInfo NavigationTransitionInfo { [MethodImpl] get; }
  }
}
