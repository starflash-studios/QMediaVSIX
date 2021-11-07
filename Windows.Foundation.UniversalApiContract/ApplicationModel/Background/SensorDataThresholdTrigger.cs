// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.SensorDataThresholdTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that responds when a threshold limit for a sensor is crossed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ISensorDataThresholdTriggerFactory), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class SensorDataThresholdTrigger : ISensorDataThresholdTrigger, IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of the SensorDataThresholdTrigger class.</summary>
    /// <param name="threshold">The threshold for a sensor that indicates when it should be triggered.</param>
    [MethodImpl]
    public extern SensorDataThresholdTrigger(ISensorDataThreshold threshold);
  }
}
