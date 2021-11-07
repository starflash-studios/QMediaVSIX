// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessDiagnosticInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2505624346, 15627, 18924, 171, 112, 79, 122, 17, 40, 5, 222)]
  [ExclusiveTo(typeof (ProcessDiagnosticInfo))]
  internal interface IProcessDiagnosticInfo2
  {
    IVector<AppDiagnosticInfo> GetAppDiagnosticInfos();

    bool IsPackaged { get; }
  }
}
