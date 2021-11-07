// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ModuleCommandResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Devices
{
  /// <summary>Represents the result of an audio device module command, executed with a call to AudioDeviceModule.SendCommand.</summary>
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class ModuleCommandResult : IModuleCommandResult
  {
    /// <summary>Gets a value that specifies the status of the audio device module command.</summary>
    /// <returns>A value that specifies the status of the audio device module command.</returns>
    public extern SendCommandStatus Status { [MethodImpl] get; }

    /// <summary>Gets a buffer containing result of the audio device module command, defined by the audio device module developer.</summary>
    /// <returns>A buffer containing result of the audio device module command.</returns>
    public extern IBuffer Result { [MethodImpl] get; }
  }
}
