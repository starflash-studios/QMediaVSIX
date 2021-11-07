// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppDiagnosticInfoStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3462997439, 4298, 16584, 169, 202, 197, 201, 101, 1, 134, 110)]
  [ExclusiveTo(typeof (AppDiagnosticInfo))]
  internal interface IAppDiagnosticInfoStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVector<AppDiagnosticInfo>> RequestInfoAsync();
  }
}
