// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.XusbDeviceSubtype
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>The device subtype of the controller.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public enum XusbDeviceSubtype
  {
    /// <summary>The device subtype is unknown.</summary>
    Unknown,
    /// <summary>The device subtype is gamepad.</summary>
    Gamepad,
    /// <summary>The device subtype is arcadepad.</summary>
    ArcadePad,
    /// <summary>The device subtype is arcadestick.</summary>
    ArcadeStick,
    /// <summary>The device subtype is flightstick.</summary>
    FlightStick,
    /// <summary>The device subtype is wheel.</summary>
    Wheel,
    /// <summary>The device subtype is guitar.</summary>
    Guitar,
    /// <summary>The device subtype is guitaralternate.</summary>
    GuitarAlternate,
    /// <summary>The device subtype is guitarbass.</summary>
    GuitarBass,
    /// <summary>The device subtype is drumkit.</summary>
    DrumKit,
    /// <summary>The device subtype is dancepad.</summary>
    DancePad,
  }
}
