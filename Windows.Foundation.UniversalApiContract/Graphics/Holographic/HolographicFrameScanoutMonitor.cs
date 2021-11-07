// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicFrameScanoutMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Allows Mixed Reality applications to obtain a stream of HolographicFrameScanoutReport objects.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class HolographicFrameScanoutMonitor : IHolographicFrameScanoutMonitor, IClosable
  {
    /// <summary>Returns a list of HolographicFrameScanoutReport objects where each report corresponds to a single scanout to the holographic display which has occurred since the last time the method was called. Note that each HolographicFrame may be scanned out multiple times.</summary>
    /// <returns>A list of HolographicFrameScanoutReport objects.</returns>
    [MethodImpl]
    public extern IVector<HolographicFrameScanoutReport> ReadReports();

    [MethodImpl]
    public extern void Close();
  }
}
