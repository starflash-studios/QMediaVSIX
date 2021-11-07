// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.SensorDataThresholdTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides data for what sensor triggered the data threshold monitoring task.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SensorDataThresholdTriggerDetails : ISensorDataThresholdTriggerDetails
  {
    /// <summary>Gets the device identifier for the device that activated the threshold trigger.</summary>
    /// <returns>The device identifier of the sensor.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the type of sensor associated with the threshold trigger.</summary>
    /// <returns>The type of sensor.</returns>
    public extern SensorType SensorType { [MethodImpl] get; }
  }
}
