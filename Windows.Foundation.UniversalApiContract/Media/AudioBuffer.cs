// Decompiled with JetBrains decompiler
// Type: Windows.Media.AudioBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Represents a buffer containing audio data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [GCPressure(amount = GCPressureAmount.Low)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AudioBuffer : IAudioBuffer, IMemoryBuffer, IClosable
  {
    /// <summary>Gets the maximum number of bytes that the buffer can hold.</summary>
    /// <returns>The maximum number of bytes that the buffer can hold.</returns>
    public extern uint Capacity { [MethodImpl] get; }

    /// <summary>Gets or sets the number of bytes currently in use in the buffer.</summary>
    /// <returns>The number of bytes currently in use in the buffer.</returns>
    public extern uint Length { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns an IMemoryBufferReference representation of the audio buffer.</summary>
    /// <returns>The IMemoryBufferReference representation of the audio buffer.</returns>
    [MethodImpl]
    public extern IMemoryBufferReference CreateReference();

    [MethodImpl]
    public extern void Close();
  }
}
