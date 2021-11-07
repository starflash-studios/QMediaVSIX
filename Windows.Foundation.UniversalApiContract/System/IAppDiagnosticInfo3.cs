// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppDiagnosticInfo3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppDiagnosticInfo))]
  [Guid(3365258813, 56673, 19557, 186, 189, 129, 161, 11, 79, 152, 21)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAppDiagnosticInfo3
  {
    [RemoteAsync]
    IAsyncOperation<AppActivationResult> LaunchAsync();
  }
}
