// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ProximitySensorReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides data for the reading– changed event of the proximity sensor.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class ProximitySensorReadingChangedEventArgs : 
    IProximitySensorReadingChangedEventArgs
  {
    /// <summary>Gets or sets the most recent proximity sensor reading.</summary>
    /// <returns>The most recent proximity sensor reading.</returns>
    public extern ProximitySensorReading Reading { [MethodImpl] get; }
  }
}
