// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.WebViewControlContentLoadingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  /// <summary>Provides data for the IWebViewControl.ContentLoading event.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class WebViewControlContentLoadingEventArgs : IWebViewControlContentLoadingEventArgs
  {
    /// <summary>Gets the Uniform Resource Identifier (URI) of the content the IWebViewControl is loading.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the content.</returns>
    public extern Uri Uri { [MethodImpl] get; }
  }
}
