// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs
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
  /// <summary>Provides data for the OnNavigatingFrom callback that can be used to cancel a navigation request from origination.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class NavigatingCancelEventArgs : 
    INavigatingCancelEventArgs,
    INavigatingCancelEventArgs2
  {
    /// <summary>Specifies whether a pending navigation should be canceled.</summary>
    /// <returns>**true** to cancel the pending cancelable navigation; **false** to continue with navigation.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the value of the *mode* parameter from the originating Navigate call.</summary>
    /// <returns>The value of the *mode* parameter from the originating Navigate call.</returns>
    public extern NavigationMode NavigationMode { [MethodImpl] get; }

    /// <summary>Gets the value of the *SourcePageType* parameter from the originating Navigate call.</summary>
    /// <returns>The value of the *SourcePageType* parameter from the originating Navigate call, as a type reference (System.Type for Microsoft .NET, a TypeName helper struct for Visual C++ component extensions (C++/CX)).</returns>
    public extern TypeName SourcePageType { [MethodImpl] get; }

    /// <summary>Gets the navigation parameter associated with this navigation.</summary>
    /// <returns>The navigation parameter.</returns>
    public extern object Parameter { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the animated transition associated with the navigation.</summary>
    /// <returns>Info about the animated transition.</returns>
    public extern NavigationTransitionInfo NavigationTransitionInfo { [MethodImpl] get; }
  }
}
