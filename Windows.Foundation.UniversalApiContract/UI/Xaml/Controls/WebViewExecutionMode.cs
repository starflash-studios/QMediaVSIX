// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewExecutionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify whether WebView hosts HTML content on the UI thread or on a non-UI thread.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebViewExecutionMode
  {
    /// <summary>Content is hosted on the UI thread.</summary>
    SameThread,
    /// <summary>Content is hosted on a background thread.</summary>
    SeparateThread,
    /// <summary>Content is hosted on a separate process off the app process. All of an app's WebView instances share the same separate process, there is not a separate process per WebView instance.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] SeparateProcess,
  }
}
