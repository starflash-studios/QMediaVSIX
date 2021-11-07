// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.SendCommandStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Specifies the status of the audio device module command, executed with a call to AudioDeviceModule.SendCommand.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum SendCommandStatus
  {
    /// <summary>The command was successful.</summary>
    Success,
    /// <summary>The command failed because device is not available.</summary>
    DeviceNotAvailable,
  }
}
