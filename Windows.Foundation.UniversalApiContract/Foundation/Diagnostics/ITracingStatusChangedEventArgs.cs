// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ITracingStatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ExclusiveTo(typeof (TracingStatusChangedEventArgs))]
  [Guid(1091270417, 65339, 18303, 156, 154, 210, 239, 218, 48, 45, 195)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITracingStatusChangedEventArgs
  {
    bool Enabled { get; }

    CausalityTraceLevel TraceLevel { get; }
  }
}
