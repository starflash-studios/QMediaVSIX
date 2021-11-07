// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.GyrometerReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides data for the gyrometer reading– changed event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class GyrometerReadingChangedEventArgs : IGyrometerReadingChangedEventArgs
  {
    /// <summary>Gets the current gyrometer reading.</summary>
    /// <returns>The current gyrometer reading.</returns>
    public extern GyrometerReading Reading { [MethodImpl] get; }
  }
}
