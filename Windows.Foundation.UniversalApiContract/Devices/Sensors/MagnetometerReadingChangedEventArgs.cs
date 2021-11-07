// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.MagnetometerReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides data for the magnetometer reading– changed event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class MagnetometerReadingChangedEventArgs : IMagnetometerReadingChangedEventArgs
  {
    /// <summary>Gets the current magnetometer reading.</summary>
    /// <returns>The current magnetometer reading.</returns>
    public extern MagnetometerReading Reading { [MethodImpl] get; }
  }
}
