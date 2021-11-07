// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.HingeAngleSensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents the hinge angle sensor in a dual-screen device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHingeAngleSensorStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  public sealed class HingeAngleSensor : IHingeAngleSensor
  {
    /// <summary>Asynchronously retrieves the current data from the hinge angle sensor.</summary>
    /// <returns>When this method completes, it returns a reference to the HingeAngleReading.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<HingeAngleReading> GetCurrentReadingAsync();

    /// <summary>Gets the device identifier.</summary>
    /// <returns>The device identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the minimum reporting threshold for the hinge angle sensor, measured in degrees.</summary>
    /// <returns>The minimum reporting threshold for the hinge angle sensor, in degrees.</returns>
    public extern double MinReportThresholdInDegrees { [MethodImpl] get; }

    /// <summary>Gets the reporting threshold for the hinge angle sensor, measured in degrees.</summary>
    /// <returns>The reporting threshold for the hinge angle sensor, in degrees.</returns>
    public extern double ReportThresholdInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the hinge angle sensor in a dual-screen device reports a change in opening angle.</summary>
    public extern event TypedEventHandler<HingeAngleSensor, HingeAngleSensorReadingChangedEventArgs> ReadingChanged;

    /// <summary>Gets an Advanced Query Syntax (AQS) string for identifying instances of the display panels in a hinged dual-screen device. This string is passed to the HingeAngleSensor.GetRelatedToAdjacentPanelsAsync method.</summary>
    /// <returns>Returns the HingeAngleSensor device selector, if it exists; otherwise, null.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Asynchronously retrieves the default hinge angle sensor.</summary>
    /// <returns>When this method completes, it returns a reference to the default HingeAngleSensor.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<HingeAngleSensor> GetDefaultAsync();

    /// <summary>Asynchronously retrieves a hinge angle sensor for two adjacent display panels.</summary>
    /// <param name="firstPanelId">The device Id of one of the hinged panels.</param>
    /// <param name="secondPanelId">The device Id of the other hinged panel.</param>
    /// <returns>When this method completes, it returns a reference to a HingeAngleSensor.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<HingeAngleSensor> GetRelatedToAdjacentPanelsAsync(
      string firstPanelId,
      string secondPanelId);

    /// <summary>Obtains the hinge angle sensor from the identifier.</summary>
    /// <param name="deviceId">The sensor identifier.</param>
    /// <returns>The HingeAngleSensor object from its identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<HingeAngleSensor> FromIdAsync(
      string deviceId);
  }
}
