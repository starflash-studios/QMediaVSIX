// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceClosedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3730839286, 51971, 19765, 172, 141, 204, 99, 3, 35, 151, 49)]
  [ExclusiveTo(typeof (AppServiceClosedEventArgs))]
  internal interface IAppServiceClosedEventArgs
  {
    AppServiceClosedStatus Status { get; }
  }
}
