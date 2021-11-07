// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.AudioDeviceModulesManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Manages the collections of audio device modules for a audio device pin instance or for a particular audio endpoint.</summary>
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IAudioDeviceModulesManagerFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class AudioDeviceModulesManager : IAudioDeviceModulesManager
  {
    /// <summary>Gets an instance of the **AudioDeviceModulesManager** class for the specified audio device ID.</summary>
    /// <param name="deviceId">The identifier of the audio device for which the **AudioDeviceModulesManager** is retrieved.</param>
    [MethodImpl]
    public extern AudioDeviceModulesManager(string deviceId);

    /// <summary>Occurs when a change occurs in one of the audio device modules associated with the audio device for which the **AudioDeviceModulesManager** was initialized.</summary>
    public extern event TypedEventHandler<AudioDeviceModulesManager, AudioDeviceModuleNotificationEventArgs> ModuleNotificationReceived;

    /// <summary>Retrieves a list of all audio device modules with the specified ID. Each audio device module in the list will have the same ID, but each will have a different value for the AudioDeviceModule.InstanceId property.</summary>
    /// <param name="moduleId">The identifier of the audio device modules to be retrieved.</param>
    /// <returns>A list of all audio device modules with the specified ID.</returns>
    [MethodImpl]
    public extern IVectorView<AudioDeviceModule> FindAllById(
      string moduleId);

    /// <summary>Retreives a list of all audio device modules associated with the audio device for which the **AudioDeviceModulesManager** was initialized.</summary>
    /// <returns>A list of all audio device modules.</returns>
    [MethodImpl]
    public extern IVectorView<AudioDeviceModule> FindAll();
  }
}
