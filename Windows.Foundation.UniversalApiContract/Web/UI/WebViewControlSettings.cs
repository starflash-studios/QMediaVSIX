// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.WebViewControlSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  /// <summary>Defines properties that enable or disable IWebViewControl features.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class WebViewControlSettings : IWebViewControlSettings
  {
    /// <summary>Gets or sets a value that indicates whether the use of JavaScript is allowed.</summary>
    /// <returns>**true** if JavaScript is allowed in the IWebViewControl; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsJavaScriptEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the use of IndexedDB is allowed.</summary>
    /// <returns>**true** if IndexedDB is allowed; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsIndexedDBEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether ScriptNotify is allowed.</summary>
    /// <returns>Whether ScriptNotify is allowed.</returns>
    public extern bool IsScriptNotifyAllowed { [MethodImpl] set; [MethodImpl] get; }
  }
}
