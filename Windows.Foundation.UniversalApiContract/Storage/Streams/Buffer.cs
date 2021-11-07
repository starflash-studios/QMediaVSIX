// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.Buffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Provides a default implementation of the IBuffer interface and its related interfaces.</summary>
  [Static(typeof (IBufferStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [Activatable(typeof (IBufferFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Buffer : IBuffer
  {
    /// <summary>Initializes a new instance of the Buffer class with the specified capacity.</summary>
    /// <param name="capacity">The maximum number of bytes that the buffer can hold.</param>
    [MethodImpl]
    public extern Buffer([Range(0, 2147483647)] uint capacity);

    /// <summary>Gets the maximum number of bytes that the buffer can hold.</summary>
    /// <returns>The maximum number of bytes that the buffer can hold.</returns>
    public extern uint Capacity { [MethodImpl] get; }

    /// <summary>Gets the number of bytes currently in use in the buffer.</summary>
    /// <returns>The number of bytes currently in use in the buffer, which is less than or equal to the capacity of the buffer.</returns>
    public extern uint Length { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates a new buffer containing a copy of a specified buffer.</summary>
    /// <param name="input">The buffer to be copied.</param>
    /// <returns>The newly created copy.</returns>
    [MethodImpl]
    public static extern Buffer CreateCopyFromMemoryBuffer(IMemoryBuffer input);

    /// <summary>Creates a MemoryBuffer from an existing IBuffer.</summary>
    /// <param name="input">The input IBuffer.</param>
    /// <returns>The newly created MemoryBuffer.</returns>
    [MethodImpl]
    public static extern MemoryBuffer CreateMemoryBufferOverIBuffer(IBuffer input);
  }
}
