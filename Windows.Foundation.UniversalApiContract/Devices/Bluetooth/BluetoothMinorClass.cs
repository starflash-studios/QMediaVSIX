// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothMinorClass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Indicates the Minor Class code of the device. These are interpreted in the context of the Major Class codes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BluetoothMinorClass
  {
    /// <summary>Fully available.</summary>
    NetworkFullyAvailable = 0,
    /// <summary>Use when a Minor Class code has not been assigned.</summary>
    Uncategorized = 0,
    /// <summary>A wearable headset device.</summary>
    AudioVideoWearableHeadset = 1,
    /// <summary>A computer desktop.</summary>
    ComputerDesktop = 1,
    /// <summary>A blood pressure monitor.</summary>
    HealthBloodPressureMonitor = 1,
    /// <summary>A joystick.</summary>
    PeripheralJoystick = 1,
    /// <summary>A cell phone.</summary>
    PhoneCellular = 1,
    /// <summary>A robot.</summary>
    ToyRobot = 1,
    /// <summary>A wristwatch.</summary>
    WearableWristwatch = 1,
    /// <summary>A hands-free device.</summary>
    AudioVideoHandsFree = 2,
    /// <summary>A computer server.</summary>
    ComputerServer = 2,
    /// <summary>A thermometer.</summary>
    HealthThermometer = 2,
    /// <summary>A gamepad.</summary>
    PeripheralGamepad = 2,
    /// <summary>A cordless phone.</summary>
    PhoneCordless = 2,
    /// <summary>A vehicle.</summary>
    ToyVehicle = 2,
    /// <summary>A pager.</summary>
    WearablePager = 2,
    /// <summary>A laptop computer.</summary>
    ComputerLaptop = 3,
    /// <summary>A weighing scale.</summary>
    HealthWeighingScale = 3,
    /// <summary>A remote control.</summary>
    PeripheralRemoteControl = 3,
    /// <summary>A smartphone.</summary>
    PhoneSmartPhone = 3,
    /// <summary>A doll or action figure.</summary>
    ToyDoll = 3,
    /// <summary>A jacket.</summary>
    WearableJacket = 3,
    /// <summary>A microphone.</summary>
    AudioVideoMicrophone = 4,
    /// <summary>A handheld PC/PDA.</summary>
    ComputerHandheld = 4,
    /// <summary>A glucose meter.</summary>
    HealthGlucoseMeter = 4,
    /// <summary>A sensing device.</summary>
    PeripheralSensing = 4,
    /// <summary>A wired modem or voice gateway.</summary>
    PhoneWired = 4,
    /// <summary>A controller.</summary>
    ToyController = 4,
    /// <summary>A helmet.</summary>
    WearableHelmet = 4,
    /// <summary>A loudspeaker.</summary>
    AudioVideoLoudspeaker = 5,
    /// <summary>A palm-sized PC/PDA.</summary>
    ComputerPalmSize = 5,
    /// <summary>A pulse oximeter.</summary>
    HealthPulseOximeter = 5,
    /// <summary>A digitizer tablet.</summary>
    PeripheralDigitizerTablet = 5,
    /// <summary>Common ISDN access.</summary>
    PhoneIsdn = 5,
    /// <summary>A game.</summary>
    ToyGame = 5,
    /// <summary>Glasses.</summary>
    WearableGlasses = 5,
    /// <summary>Headphones.</summary>
    AudioVideoHeadphones = 6,
    /// <summary>A wearable, watch-sized, computer.</summary>
    ComputerWearable = 6,
    /// <summary>A heart rate or pulse monitor.</summary>
    HealthHeartRateMonitor = 6,
    /// <summary>A card reader.</summary>
    PeripheralCardReader = 6,
    /// <summary>Portable audio device.</summary>
    AudioVideoPortableAudio = 7,
    /// <summary>A tablet computer.</summary>
    ComputerTablet = 7,
    /// <summary>A health data display.</summary>
    HealthHealthDataDisplay = 7,
    /// <summary>A digital pen.</summary>
    PeripheralDigitalPen = 7,
    /// <summary>A car audio device.</summary>
    AudioVideoCarAudio = 8,
    /// <summary>A step counter.</summary>
    HealthStepCounter = 8,
    /// <summary>1% to 17% utilized.</summary>
    NetworkUsed01To17Percent = 8,
    /// <summary>A handheld scanner for bar codes, RFID, etc</summary>
    PeripheralHandheldScanner = 8,
    /// <summary>A set-top box.</summary>
    AudioVideoSetTopBox = 9,
    /// <summary>A body composition analyzer.</summary>
    HealthBodyCompositionAnalyzer = 9,
    /// <summary>A handheld gesture input device, such as a "wand" form factor device.</summary>
    PeripheralHandheldGesture = 9,
    /// <summary>A HiFi audio device.</summary>
    AudioVideoHifiAudioDevice = 10, // 0x0000000A
    /// <summary>A peak flow monitor.</summary>
    HealthPeakFlowMonitor = 10, // 0x0000000A
    /// <summary>A VCR.</summary>
    AudioVideoVcr = 11, // 0x0000000B
    /// <summary>A medication monitor.</summary>
    HealthMedicationMonitor = 11, // 0x0000000B
    /// <summary>A video camera.</summary>
    AudioVideoVideoCamera = 12, // 0x0000000C
    /// <summary>A knee prosthesis.</summary>
    HealthKneeProsthesis = 12, // 0x0000000C
    /// <summary>A camcorder.</summary>
    AudioVideoCamcorder = 13, // 0x0000000D
    /// <summary>An ankle prosthesis.</summary>
    HealthAnkleProsthesis = 13, // 0x0000000D
    /// <summary>A video monitor.</summary>
    AudioVideoVideoMonitor = 14, // 0x0000000E
    /// <summary>A generic health manager.</summary>
    HealthGenericHealthManager = 14, // 0x0000000E
    /// <summary>A video display and loudspeaker.</summary>
    AudioVideoVideoDisplayAndLoudspeaker = 15, // 0x0000000F
    /// <summary>A personal mobility device.</summary>
    HealthPersonalMobilityDevice = 15, // 0x0000000F
    /// <summary>A video conferencing device.</summary>
    AudioVideoVideoConferencing = 16, // 0x00000010
    /// <summary>17% to 33% utilized.</summary>
    NetworkUsed17To33Percent = 16, // 0x00000010
    /// <summary>A gaming console or toy.</summary>
    AudioVideoGamingOrToy = 18, // 0x00000012
    /// <summary>335 to 50% utilized.</summary>
    NetworkUsed33To50Percent = 24, // 0x00000018
    /// <summary>50% to 67% utilized.</summary>
    NetworkUsed50To67Percent = 32, // 0x00000020
    /// <summary>67% to 83% utilized.</summary>
    NetworkUsed67To83Percent = 40, // 0x00000028
    /// <summary>83% to 99% utilized.</summary>
    NetworkUsed83To99Percent = 48, // 0x00000030
    /// <summary>Network service is not available.</summary>
    NetworkNoServiceAvailable = 56, // 0x00000038
  }
}
