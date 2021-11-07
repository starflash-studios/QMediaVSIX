// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.PedometerDataThreshold
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>A threshold for the Pedometer sensor. When the threshold conditions are met, the sensor trigger will activate.</summary>
  [Activatable(typeof (IPedometerDataThresholdFactory), 131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PedometerDataThreshold : ISensorDataThreshold
  {
    /// <summary>Creates a PedometerDataThreshold object.</summary>
    /// <param name="sensor">The pedometer sensor.</param>
    /// <param name="stepGoal">The number of steps before the threshold is exceeded and the background task is activated.</param>
    [MethodImpl]
    public extern PedometerDataThreshold(Pedometer sensor, int stepGoal);
  }
}
