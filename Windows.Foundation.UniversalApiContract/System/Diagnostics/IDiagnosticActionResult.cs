// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IDiagnosticActionResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [Guid(3261440662, 59195, 16535, 178, 143, 52, 66, 240, 61, 216, 49)]
  [ExclusiveTo(typeof (DiagnosticActionResult))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IDiagnosticActionResult
  {
    HResult ExtendedError { get; }

    ValueSet Results { get; }
  }
}
