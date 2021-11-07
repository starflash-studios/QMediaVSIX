// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.WebViewControlScriptNotifyEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  /// <summary>Contains information for the Windows.Web.UI.IWebViewControl.ScriptNotify event.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class WebViewControlScriptNotifyEventArgs : IWebViewControlScriptNotifyEventArgs
  {
    /// <summary>Gets the Uri that originated the ScriptNotify.</summary>
    /// <returns>The Uri that originated the ScriptNotify.</returns>
    public extern Uri Uri { [MethodImpl] get; }

    /// <summary>Gets the string value passed to the app.</summary>
    /// <returns>The string value passed to the app.</returns>
    public extern string Value { [MethodImpl] get; }
  }
}
