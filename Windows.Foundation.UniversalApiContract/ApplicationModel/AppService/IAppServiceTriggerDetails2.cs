// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceTriggerDetails2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppServiceTriggerDetails))]
  [Guid(3896333490, 10444, 17394, 180, 101, 192, 72, 46, 89, 226, 220)]
  internal interface IAppServiceTriggerDetails2
  {
    bool IsRemoteSystemConnection { get; }
  }
}
