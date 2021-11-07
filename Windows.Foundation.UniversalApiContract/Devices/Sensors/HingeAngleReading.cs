// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.HingeAngleReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides access to the data exposed by the hinge angle sensor in a dual-screen device.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class HingeAngleReading : IHingeAngleReading
  {
    /// <summary>Gets the time when the hinge angle reading was obtained.</summary>
    /// <returns>The time when the HingeAngleSensor reading was obtained.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets the angle reported by the hinge angle sensor.</summary>
    /// <returns>The angle reported by the HingeAngleSensor.</returns>
    public extern double AngleInDegrees { [MethodImpl] get; }

    /// <summary>Gets a collection of key-value pairs that represent data properties reported by the sensor for the given reading.</summary>
    /// <returns>A collection of key-value pairs that represent data properties reported by the sensor for the given reading.</returns>
    public extern IMapView<string, object> Properties { [MethodImpl] get; }
  }
}
