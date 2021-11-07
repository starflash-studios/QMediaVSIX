// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.AudioDeviceModule
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Devices
{
  /// <summary>Represents a single audio device module, which may be a hardware effect processing unit or any other audio configuration module defined by an audio driver.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class AudioDeviceModule : IAudioDeviceModule
  {
    /// <summary>Gets the GUID identifier of the module, which is defined by the audio device module owner.</summary>
    /// <returns>The GUID identifier of the module</returns>
    public extern string ClassId { [MethodImpl] get; }

    /// <summary>Gets the friendly name of the audio device module for display in UI.</summary>
    /// <returns>The friendly name of the audio device module.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets an identifier, defined by the driver developer, that disambiguates between multiple instances of the same module class in the driver topology.</summary>
    /// <returns>An identifier that disambiguates between multiple instances of the same module class in the driver topology.</returns>
    public extern uint InstanceId { [MethodImpl] get; }

    /// <summary>Gets the major version of the audio device module.</summary>
    /// <returns>The major version of the audio device module.</returns>
    public extern uint MajorVersion { [MethodImpl] get; }

    /// <summary>Gets the minor version of the audio device module.</summary>
    /// <returns>The minor version of the audio device module.</returns>
    public extern uint MinorVersion { [MethodImpl] get; }

    /// <summary>Asynchronously sends data to the audio device module and receives the result.</summary>
    /// <param name="Command">A buffer containing the command data to send to the audio device module.</param>
    /// <returns>An asynchronous operation the returns a ModuleCommandResult upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ModuleCommandResult> SendCommandAsync(
      IBuffer Command);
  }
}
