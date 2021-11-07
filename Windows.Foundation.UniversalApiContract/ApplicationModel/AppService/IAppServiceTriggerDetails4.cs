// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceTriggerDetails4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(293974400, 34913, 24112, 171, 85, 28, 244, 208, 139, 191, 109)]
  [ExclusiveTo(typeof (AppServiceTriggerDetails))]
  internal interface IAppServiceTriggerDetails4
  {
    string CallerRemoteConnectionToken { get; }
  }
}
