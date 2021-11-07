// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.BufferMediaFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Represents a frame from a MediaFrameSource that provides data in an IBuffer.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  public sealed class BufferMediaFrame : IBufferMediaFrame
  {
    /// <summary>Gets the MediaFrameReference wrapper object associated with the BufferMediaFrame, which provides access to format information and other properties of the media frame.</summary>
    /// <returns>The MediaFrameReference wrapper object associated with the BufferMediaFrame.</returns>
    public extern MediaFrameReference FrameReference { [MethodImpl] get; }

    /// <summary>Gets the buffer that contains the data for the BufferMediaFrame.</summary>
    /// <returns>The buffer that contains the data for the BufferMediaFrame.</returns>
    public extern IBuffer Buffer { [MethodImpl] get; }
  }
}
