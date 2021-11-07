// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Altimeter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides an interface for an altimetric sensor to measure the relative altitude.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAltimeterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Altimeter : IAltimeter, IAltimeter2
  {
    /// <summary>Gets the current reading for the altimeter.</summary>
    /// <returns>The current alititude reading for this sensor.</returns>
    [MethodImpl]
    public extern AltimeterReading GetCurrentReading();

    /// <summary>Gets the device identifier.</summary>
    /// <returns>The device identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>The smallest report interval that is supported by this altimeter sensor.</summary>
    /// <returns>The smallest ReportInterval supported by the sensor.</returns>
    public extern uint MinimumReportInterval { [MethodImpl] get; }

    /// <summary>Gets or sets the current report interval for the altimeter.</summary>
    /// <returns>The current report interval.</returns>
    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs each time the altimeter sensor reports a new value.</summary>
    public extern event TypedEventHandler<Altimeter, AltimeterReadingChangedEventArgs> ReadingChanged;

    /// <summary>Gets or sets the delay between batches of sensor information.</summary>
    /// <returns>The delay between batches of sensor information in milliseconds.</returns>
    public extern uint ReportLatency { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the maximum number of events that can be batched by the sensor.</summary>
    /// <returns>The maximum number of batched events.</returns>
    public extern uint MaxBatchSize { [MethodImpl] get; }

    /// <summary>Returns the default altimeter sensor.</summary>
    /// <returns>The default altimeter.</returns>
    [MethodImpl]
    public static extern Altimeter GetDefault();
  }
}
