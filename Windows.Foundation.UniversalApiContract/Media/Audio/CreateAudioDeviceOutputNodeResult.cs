// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.CreateAudioDeviceOutputNodeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents the result of attempting to create an audio device output node.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CreateAudioDeviceOutputNodeResult : 
    ICreateAudioDeviceOutputNodeResult,
    ICreateAudioDeviceOutputNodeResult2
  {
    /// <summary>Gets the result status of an operation to create an AudioDeviceOutputNode with a call to CreateDeviceOutputNodeAsync.</summary>
    /// <returns>An enumeration value indicating node creation status. If the result status is **Success**, get the instance of the node with the Node property.</returns>
    public extern AudioDeviceNodeCreationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the audio device output node.</summary>
    /// <returns>An object representing the audio device output node.</returns>
    public extern AudioDeviceOutputNode DeviceOutputNode { [MethodImpl] get; }

    /// <summary>Gets the extended error code associated with the creation of a AudioDeviceOutputNode object.</summary>
    /// <returns>The extended error code associated with the creation of a AudioDeviceOutputNode object.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
