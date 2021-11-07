// Decompiled with JetBrains decompiler
// Type: Windows.Perception.PerceptionTimestamp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception
{
  /// <summary>Represents a particular prediction of the future, or a snapshot of the past.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class PerceptionTimestamp : IPerceptionTimestamp, IPerceptionTimestamp2
  {
    /// <summary>Gets the specific time that is the subject of this timestamp.</summary>
    /// <returns>The time.</returns>
    public extern DateTime TargetTime { [MethodImpl] get; }

    /// <summary>For timestamps about the future, gets the span of time between when the prediction was made and TargetTime.</summary>
    /// <returns>The prediction duration.</returns>
    public extern TimeSpan PredictionAmount { [MethodImpl] get; }

    /// <summary>Gets the specific time that is the subject of this timestamp, represented in the system-relative QueryPerformanceCounter (QPC) time domain.</summary>
    /// <returns>The system-relative QPC time.</returns>
    public extern TimeSpan SystemRelativeTargetTime { [MethodImpl] get; }
  }
}
