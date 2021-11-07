// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceTriggerDetails3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [Guid(4225179169, 31033, 20072, 158, 60, 119, 128, 20, 122, 171, 182)]
  [ExclusiveTo(typeof (AppServiceTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAppServiceTriggerDetails3
  {
    [RemoteAsync]
    IAsyncOperation<bool> CheckCallerForCapabilityAsync(string capabilityName);
  }
}
