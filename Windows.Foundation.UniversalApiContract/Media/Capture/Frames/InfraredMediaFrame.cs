// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.InfraredMediaFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Represents a VideoMediaFrame that contains infrared video data.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class InfraredMediaFrame : IInfraredMediaFrame
  {
    /// <summary>Gets the MediaFrameReference wrapper object associated with the InfraredMediaFrame, which provides access to format information and other properties of the media frame.</summary>
    /// <returns>The MediaFrameReference wrapper object associated with the InfraredMediaFrame.</returns>
    public extern MediaFrameReference FrameReference { [MethodImpl] get; }

    /// <summary>Gets the VideoMediaFrame associated with the InfraredMediaFrame.</summary>
    /// <returns>The VideoMediaFrame associated with the InfraredMediaFrame.</returns>
    public extern VideoMediaFrame VideoMediaFrame { [MethodImpl] get; }

    /// <summary>Gets a value specifying whether the infrared media frame is illuminated.</summary>
    /// <returns>True if the infrared media frame is illuminated; otherwise, false.</returns>
    public extern bool IsIlluminated { [MethodImpl] get; }
  }
}
