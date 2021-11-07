// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverGameControllerDeviceUsageMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Specifies how game controller input is being used when transmitted to a Miracast Transmitter. Game controller input can be transmitted as-is, or it can be mapped to mouse and keyboard input.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum MiracastReceiverGameControllerDeviceUsageMode
  {
    /// <summary>Input from the game controller is used as-is.</summary>
    AsGameController,
    /// <summary>Input from the game controller is converted to mouse and keyboard input.</summary>
    AsMouseAndKeyboard,
  }
}
