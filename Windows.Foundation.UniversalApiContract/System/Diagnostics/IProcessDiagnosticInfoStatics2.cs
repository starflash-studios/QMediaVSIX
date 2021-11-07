// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessDiagnosticInfoStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (ProcessDiagnosticInfo))]
  [Guid(1250334871, 39065, 19012, 162, 155, 9, 22, 99, 190, 9, 182)]
  internal interface IProcessDiagnosticInfoStatics2
  {
    ProcessDiagnosticInfo TryGetForProcessId(uint processId);
  }
}
