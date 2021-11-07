// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IDiagnosticInvokerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (DiagnosticInvoker))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1559943390, 61788, 17748, 168, 19, 193, 19, 195, 136, 27, 9)]
  internal interface IDiagnosticInvokerStatics
  {
    DiagnosticInvoker GetDefault();

    DiagnosticInvoker GetForUser(User user);

    bool IsSupported { get; }
  }
}
