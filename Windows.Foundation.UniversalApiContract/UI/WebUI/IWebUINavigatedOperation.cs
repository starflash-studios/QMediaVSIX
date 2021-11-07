// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUINavigatedOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2056675080, 33154, 19081, 171, 103, 132, 146, 232, 117, 13, 75)]
  [ExclusiveTo(typeof (WebUINavigatedOperation))]
  internal interface IWebUINavigatedOperation
  {
    WebUINavigatedDeferral GetDeferral();
  }
}
