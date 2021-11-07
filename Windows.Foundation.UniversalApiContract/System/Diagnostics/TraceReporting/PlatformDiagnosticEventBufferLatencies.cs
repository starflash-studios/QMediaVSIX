// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticEventBufferLatencies
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  /// <summary>Specifies the kinds of network connections that can be used to transfer diagnostic data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Flags]
  public enum PlatformDiagnosticEventBufferLatencies : uint
  {
    /// <summary>Trace data will be transferred unless the device is on a metered connection.</summary>
    Normal = 1,
    /// <summary>Less strict than **Normal**. If, after three days, there has been no opportunity to connect over a non-cellular connection, trace data will be transferred even if the device is still on a cellular connection.</summary>
    CostDeferred = 2,
    /// <summary>Trace data will be uploaded as soon as a network connection (of any kind) is available.</summary>
    Realtime = 4,
  }
}
