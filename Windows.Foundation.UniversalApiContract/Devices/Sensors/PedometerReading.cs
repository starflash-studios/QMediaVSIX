// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.PedometerReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents a pedometer reading.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PedometerReading : IPedometerReading
  {
    /// <summary>Indicates the type of steps taken for this pedometer reading.</summary>
    /// <returns>The type of step taken.</returns>
    public extern PedometerStepKind StepKind { [MethodImpl] get; }

    /// <summary>Gets the total number of steps taken for this pedometer reading.</summary>
    /// <returns>The total number of steps taken.</returns>
    public extern int CumulativeSteps { [MethodImpl] get; }

    /// <summary>Gets the time for the most recent pedometer reading.</summary>
    /// <returns>The time when the pedometer reported the reading.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets the amount of time that has elapsed for this pedometer reading.</summary>
    /// <returns>The amount of elapsed time for the current reading of cumulative steps. This value is given in milliseconds.</returns>
    public extern TimeSpan CumulativeStepsDuration { [MethodImpl] get; }
  }
}
