// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppDiagnosticInfoStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(95570822, 4096, 19600, 187, 159, 114, 53, 7, 28, 80, 254)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (AppDiagnosticInfo))]
  internal interface IAppDiagnosticInfoStatics2
  {
    AppDiagnosticInfoWatcher CreateWatcher();

    [RemoteAsync]
    IAsyncOperation<DiagnosticAccessStatus> RequestAccessAsync();

    [RemoteAsync]
    IAsyncOperation<IVector<AppDiagnosticInfo>> RequestInfoForPackageAsync(
      string packageFamilyName);

    [RemoteAsync]
    [Overload("RequestInfoForAppAsync")]
    [DefaultOverload]
    IAsyncOperation<IVector<AppDiagnosticInfo>> RequestInfoForAppAsync();

    [RemoteAsync]
    [Overload("RequestInfoForAppUserModelId")]
    IAsyncOperation<IVector<AppDiagnosticInfo>> RequestInfoForAppAsync(
      string appUserModelId);
  }
}
