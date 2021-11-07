// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceRequestReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ExclusiveTo(typeof (AppServiceRequestReceivedEventArgs))]
  [Guid(1846682464, 65381, 17582, 158, 69, 133, 127, 228, 24, 6, 129)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppServiceRequestReceivedEventArgs
  {
    AppServiceRequest Request { get; }

    AppServiceDeferral GetDeferral();
  }
}
