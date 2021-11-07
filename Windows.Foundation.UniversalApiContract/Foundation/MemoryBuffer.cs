// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.MemoryBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a reference counted memory buffer.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IMemoryBufferFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MemoryBuffer : IMemoryBuffer, IClosable
  {
    /// <summary>Initializes a new MemoryBuffer instance with the specified capacity.</summary>
    /// <param name="capacity">The desired size of the new memory buffer.</param>
    [MethodImpl]
    public extern MemoryBuffer([Range(0, 2147483647)] uint capacity);

    /// <summary>Returns a new managed object that implements the IMemoryBufferReference interface.</summary>
    /// <returns>A new managed object that implements the IMemoryBufferReference interface.</returns>
    [MethodImpl]
    public extern IMemoryBufferReference CreateReference();

    [MethodImpl]
    public extern void Close();
  }
}
