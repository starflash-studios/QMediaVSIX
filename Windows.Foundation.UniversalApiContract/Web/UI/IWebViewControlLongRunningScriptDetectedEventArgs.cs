// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControlLongRunningScriptDetectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  [ExclusiveTo(typeof (WebViewControlLongRunningScriptDetectedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(711875514, 39092, 17852, 187, 235, 15, 105, 206, 73, 197, 153)]
  internal interface IWebViewControlLongRunningScriptDetectedEventArgs
  {
    TimeSpan ExecutionTime { get; }

    bool StopPageScriptExecution { get; set; }
  }
}
