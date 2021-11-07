// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IBufferMediaFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (BufferMediaFrame))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3048297415, 39812, 16482, 183, 156, 163, 101, 178, 89, 104, 84)]
  internal interface IBufferMediaFrame
  {
    MediaFrameReference FrameReference { get; }

    IBuffer Buffer { get; }
  }
}
