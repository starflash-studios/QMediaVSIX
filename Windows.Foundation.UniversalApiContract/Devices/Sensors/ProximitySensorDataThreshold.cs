// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ProximitySensorDataThreshold
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>A threshold for the ProximitySensor. When the threshold conditions are met, the sensor trigger will activate.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IProximitySensorDataThresholdFactory), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProximitySensorDataThreshold : ISensorDataThreshold
  {
    /// <summary>Creates a ProximitySensorDataThreshold object.</summary>
    /// <param name="sensor">The proximity sensor.</param>
    [MethodImpl]
    public extern ProximitySensorDataThreshold(ProximitySensor sensor);
  }
}
