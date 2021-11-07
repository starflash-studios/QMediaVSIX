// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.WebViewControlLongRunningScriptDetectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  /// <summary>Provides data for the IWebViewControl.LongRunningScriptDetected event.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class WebViewControlLongRunningScriptDetectedEventArgs : 
    IWebViewControlLongRunningScriptDetectedEventArgs
  {
    /// <summary>Gets the number of milliseconds that the IWebViewControl has been executing a long-running script.</summary>
    /// <returns>The number of milliseconds the script has been running.</returns>
    public extern TimeSpan ExecutionTime { [MethodImpl] get; }

    /// <summary>Halts a long-running script executing in a IWebViewControl.</summary>
    /// <returns>**true** to halt the script; otherwise, **false**.</returns>
    public extern bool StopPageScriptExecution { [MethodImpl] get; [MethodImpl] set; }
  }
}
