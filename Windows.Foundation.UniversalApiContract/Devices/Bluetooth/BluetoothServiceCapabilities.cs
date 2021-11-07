// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothServiceCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Indicates the service capabilities of a device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum BluetoothServiceCapabilities : uint
  {
    /// <summary>None.</summary>
    None = 0,
    /// <summary>Limited Discoverable Mode.</summary>
    LimitedDiscoverableMode = 1,
    /// <summary>Positioning or location identification.</summary>
    PositioningService = 8,
    /// <summary>Networking, for example, LAN, Ad hoc.</summary>
    NetworkingService = 16, // 0x00000010
    /// <summary>Rendering, for example, printer, speakers.</summary>
    RenderingService = 32, // 0x00000020
    /// <summary>Capturing, for example, scanner, microphone.</summary>
    CapturingService = 64, // 0x00000040
    /// <summary>Object Transfer, for example, v-Inbox, v-folder.</summary>
    ObjectTransferService = 128, // 0x00000080
    /// <summary>Audio, for example, speaker, microphone, headset service.</summary>
    AudioService = 256, // 0x00000100
    /// <summary>Telephony, for example cordless, modem, headset service.</summary>
    TelephoneService = 512, // 0x00000200
    /// <summary>Information, for example, web server, WAP server.</summary>
    InformationService = 1024, // 0x00000400
  }
}
