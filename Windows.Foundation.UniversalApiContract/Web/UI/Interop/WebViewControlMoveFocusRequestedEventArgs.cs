// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.WebViewControlMoveFocusRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI.Interop
{
  /// <summary>This class contains information for the Windows.Web.UI.Interop.WebViewControl.MoveFocusRequested event.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class WebViewControlMoveFocusRequestedEventArgs : 
    IWebViewControlMoveFocusRequestedEventArgs
  {
    /// <summary>Gets or sets the move focus reason.</summary>
    /// <returns>The move focus reason.</returns>
    public extern WebViewControlMoveFocusReason Reason { [MethodImpl] get; }
  }
}
