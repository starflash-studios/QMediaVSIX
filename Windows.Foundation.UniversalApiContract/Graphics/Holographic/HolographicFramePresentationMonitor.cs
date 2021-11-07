// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicFramePresentationMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Monitors an independent stream of frame presentation reports from a HolographicSpace.</summary>
  /// <deprecated type="deprecate">Use HolographicFrameScanoutMonitor instead of HolographicFramePresentationMonitor. For more info, see MSDN.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Deprecated("Use HolographicFrameScanoutMonitor instead of HolographicFramePresentationMonitor. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public sealed class HolographicFramePresentationMonitor : 
    IHolographicFramePresentationMonitor,
    IClosable
  {
    /// <summary>Returns a list of reports for frame presentations which have occurred since the last time the method was called.</summary>
    /// <deprecated type="deprecate">Use HolographicFrameScanoutMonitor instead of HolographicFramePresentationMonitor. For more info, see MSDN.</deprecated>
    /// <returns>The report list.</returns>
    [Deprecated("Use HolographicFrameScanoutMonitor instead of HolographicFramePresentationMonitor. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<HolographicFramePresentationReport> ReadReports();

    [MethodImpl]
    public extern void Close();
  }
}
