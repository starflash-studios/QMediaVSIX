// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ISystemDiagnosticInfoStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  [Guid(2044645769, 27385, 19881, 164, 34, 21, 247, 50, 85, 179, 235)]
  [ExclusiveTo(typeof (SystemDiagnosticInfo))]
  internal interface ISystemDiagnosticInfoStatics2
  {
    bool IsArchitectureSupported(ProcessorArchitecture type);

    ProcessorArchitecture PreferredArchitecture { get; }
  }
}
