// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.NavigationFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Navigation
{
  /// <summary>Provides event data for the WebView.NavigationFailed and Frame.NavigationFailed events.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class NavigationFailedEventArgs : INavigationFailedEventArgs
  {
    /// <summary>Gets the result code for the exception that is associated with the failed navigation.</summary>
    /// <returns>A system exception result code.</returns>
    public extern HResult Exception { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the failure event has been handled.</summary>
    /// <returns>**true** if the failure event is handled; **false** if the failure event is not yet handled.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the data type of the target page.</summary>
    /// <returns>The data type of the target page, as a type reference (System.Type for Microsoft .NET, a TypeName helper struct for Visual C++ component extensions (C++/CX)).</returns>
    public extern TypeName SourcePageType { [MethodImpl] get; }
  }
}
