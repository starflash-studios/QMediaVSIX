// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.LampArrayKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights
{
  /// <summary>The type of physical device the LampArray is part of.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum LampArrayKind
  {
    /// <summary>No Kind specified for this device.</summary>
    Undefined,
    /// <summary>Is part of a keyboard or keypad.</summary>
    Keyboard,
    /// <summary>Is part of a mouse.</summary>
    Mouse,
    /// <summary>Is part of a game controller (for example, gamepad, flightstick, sailing simulation device).</summary>
    GameController,
    /// <summary>Is part of a more general peripheral/accessory (for example, speakers, mousepad, microphone, webcam).</summary>
    Peripheral,
    /// <summary>Illuminates a room/performance-stage/area (for example, room light-bulbs, spotlights, washlights, strobelights, booth-strips, billboard/sign, camera-flash).</summary>
    Scene,
    /// <summary>Is part of a notification device.</summary>
    Notification,
    /// <summary>Is part of an internal PC case component (for example, RAM-stick, motherboard, fan).</summary>
    Chassis,
    /// <summary>Is embedded in a wearable accessory (for example, audio-headset, wristband, watch, shoes).</summary>
    Wearable,
    /// <summary>Is embedded in a piece of furniture (for example, chair, desk, bookcase).</summary>
    Furniture,
    /// <summary>Is embedded in an artwork (for example, painting, sculpture).</summary>
    Art,
  }
}
