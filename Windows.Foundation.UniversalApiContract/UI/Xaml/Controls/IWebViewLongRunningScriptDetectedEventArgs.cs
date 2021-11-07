// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewLongRunningScriptDetectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WebViewLongRunningScriptDetectedEventArgs))]
  [Guid(4092600491, 42092, 17072, 158, 254, 105, 118, 77, 92, 255, 166)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebViewLongRunningScriptDetectedEventArgs
  {
    TimeSpan ExecutionTime { get; }

    bool StopPageScriptExecution { get; set; }
  }
}
