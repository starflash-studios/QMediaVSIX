// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [Guid(2292374700, 44328, 16824, 128, 187, 189, 241, 178, 22, 158, 25)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppServiceTriggerDetails))]
  internal interface IAppServiceTriggerDetails
  {
    string Name { get; }

    string CallerPackageFamilyName { get; }

    AppServiceConnection AppServiceConnection { get; }
  }
}
