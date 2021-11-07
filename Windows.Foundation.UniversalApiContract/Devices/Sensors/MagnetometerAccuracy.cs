// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.MagnetometerAccuracy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>The sensor's accuracy.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MagnetometerAccuracy
  {
    /// <summary>The accuracy is currently not available, typically because the driver can't report it.</summary>
    Unknown,
    /// <summary>The actual and reported values have a high degree of inaccuracy.</summary>
    Unreliable,
    /// <summary>The actual and reported values differ but may be accurate enough for some application.</summary>
    Approximate,
    /// <summary>The actual and reported values are accurate.</summary>
    High,
  }
}
