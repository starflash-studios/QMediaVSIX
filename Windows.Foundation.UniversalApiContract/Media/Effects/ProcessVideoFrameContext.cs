// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.ProcessVideoFrameContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  /// <summary>Provides context for performing a custom video effect operation within the ProcessFrame method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [GCPressure(amount = GCPressureAmount.High)]
  public sealed class ProcessVideoFrameContext : IProcessVideoFrameContext
  {
    /// <summary>Gets the input frame for a video effect operation.</summary>
    /// <returns>The input frame for a video effect operation.</returns>
    public extern VideoFrame InputFrame { [MethodImpl] get; }

    /// <summary>Gets the output frame for a video effect operation.</summary>
    /// <returns>The output frame for a video effect operation.</returns>
    public extern VideoFrame OutputFrame { [MethodImpl] get; }
  }
}
