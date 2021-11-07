// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.SimpleOrientation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Indicates the orientation of the device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SimpleOrientation
  {
    /// <summary>The device is not rotated.</summary>
    NotRotated,
    /// <summary>The device is rotated 90-degrees counter-clockwise.</summary>
    Rotated90DegreesCounterclockwise,
    /// <summary>The device is rotated 180-degrees counter-clockwise.</summary>
    Rotated180DegreesCounterclockwise,
    /// <summary>The device is rotated 270-degrees counter-clockwise.</summary>
    Rotated270DegreesCounterclockwise,
    /// <summary>The device is face-up and the display is visible to the user.</summary>
    Faceup,
    /// <summary>The device is face-down and the display is hidden from the user.</summary>
    Facedown,
  }
}
