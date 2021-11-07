// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUIBackgroundTaskInstanceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2625262225, 6574, 19619, 185, 75, 254, 78, 199, 68, 167, 64)]
  [ExclusiveTo(typeof (WebUIBackgroundTaskInstance))]
  internal interface IWebUIBackgroundTaskInstanceStatics
  {
    IWebUIBackgroundTaskInstance Current { get; }
  }
}
