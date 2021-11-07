// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IApplicationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationTrigger))]
  [Guid(189171248, 38260, 18732, 158, 147, 26, 58, 230, 51, 95, 233)]
  internal interface IApplicationTrigger : IBackgroundTrigger
  {
    [RemoteAsync]
    [Overload("RequestAsync")]
    IAsyncOperation<ApplicationTriggerResult> RequestAsync();

    [Overload("RequestAsyncWithArguments")]
    IAsyncOperation<ApplicationTriggerResult> RequestAsync(
      ValueSet arguments);
  }
}
