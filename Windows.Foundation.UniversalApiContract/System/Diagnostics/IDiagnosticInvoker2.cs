// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IDiagnosticInvoker2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (DiagnosticInvoker))]
  [Guid(3820983388, 5466, 19282, 168, 236, 7, 12, 68, 249, 80, 0)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IDiagnosticInvoker2
  {
    [RemoteAsync]
    IAsyncOperationWithProgress<DiagnosticActionResult, DiagnosticActionState> RunDiagnosticActionFromStringAsync(
      string context);
  }
}
