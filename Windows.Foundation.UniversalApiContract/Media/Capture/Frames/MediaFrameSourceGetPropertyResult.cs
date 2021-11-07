// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameSourceGetPropertyResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Represents the value of a MediaFrameSource property, if it was successfully retrieved, and the result status of the get operation.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaFrameSourceGetPropertyResult : IMediaFrameSourceGetPropertyResult
  {
    /// <summary>Gets a value describing the result status of the get operation that attempted to retrieve the MediaFrameSource property value.</summary>
    /// <returns>A value describing the result status of the get operation</returns>
    public extern MediaFrameSourceGetPropertyStatus Status { [MethodImpl] get; }

    /// <summary>Gets an object containing the value of a MediaFrameSource property, if the value was successfully retreived.</summary>
    /// <returns>An object containing the value of a media frame source property.</returns>
    public extern object Value { [MethodImpl] [return: Variant] get; }
  }
}
