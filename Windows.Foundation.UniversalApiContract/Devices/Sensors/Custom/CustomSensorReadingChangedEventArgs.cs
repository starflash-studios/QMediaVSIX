// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Custom.CustomSensorReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors.Custom
{
  /// <summary>Represents data for the reading– changed event of the custom sensor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CustomSensorReadingChangedEventArgs : ICustomSensorReadingChangedEventArgs
  {
    /// <summary>Gets the most recent sensor reading.</summary>
    /// <returns>The most recent sensor reading.</returns>
    public extern CustomSensorReading Reading { [MethodImpl] get; }
  }
}
