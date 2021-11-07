// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ActivitySensorTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents details about the sensor triggering.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ActivitySensorTriggerDetails : IActivitySensorTriggerDetails
  {
    /// <summary>Reads reports about the sensor triggering.</summary>
    /// <returns>Returns a list of ActivitySensorReadingChangeReport objects that provides data for the sensor trigger.</returns>
    [MethodImpl]
    public extern IVectorView<ActivitySensorReadingChangeReport> ReadReports();
  }
}
