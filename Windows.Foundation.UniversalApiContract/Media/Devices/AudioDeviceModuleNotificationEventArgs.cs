// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.AudioDeviceModuleNotificationEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Devices
{
  /// <summary>Provides data for the AudioDeviceModulesManager.ModuleNotificationReceived event which is raised when audio device module changes occur.</summary>
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class AudioDeviceModuleNotificationEventArgs : 
    IAudioDeviceModuleNotificationEventArgs
  {
    /// <summary>Gets the audio device module that triggered the change event.</summary>
    /// <returns>The audio device module that triggered the change event.</returns>
    public extern AudioDeviceModule Module { [MethodImpl] get; }

    /// <summary>Gets a buffer containing data that identifies the change that occurred in the module. This data is defined by the module developer.</summary>
    /// <returns>
    /// </returns>
    public extern IBuffer NotificationData { [MethodImpl] get; }
  }
}
