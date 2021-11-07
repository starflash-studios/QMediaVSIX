// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverCursorImageChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Storage.Streams;

namespace Windows.Media.Miracast
{
  /// <summary>An object representing the channel for transmitting mouse cursor images from a Miracast Transmitter to a Miracast Receiver.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MiracastReceiverCursorImageChannel : IMiracastReceiverCursorImageChannel
  {
    /// <summary>Gets a value that specifies if the cursor image channel has been enabled by the Miracast Receiver.</summary>
    /// <returns>True if the cursor image channel has enabled by the Miracast Receiver.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Gets the maximum width and height of the cursor image PNG bitmap, in pixels.</summary>
    /// <returns>The maximum width and height of the cursor image PNG bitmap, in pixels.</returns>
    public extern SizeInt32 MaxImageSize { [MethodImpl] get; }

    /// <summary>Gets the coordinates of the upper-left corner of the cursor image, in pixels.</summary>
    /// <returns>The coordinates of the upper-left corner of the cursor image, in pixels.</returns>
    public extern PointInt32 Position { [MethodImpl] get; }

    /// <summary>Gets the cursor image as a PNG image bitmap.</summary>
    /// <returns>A stream object, containing the cursor image in the form of a PNG image bitmap.</returns>
    public extern IRandomAccessStreamWithContentType ImageStream { [MethodImpl] get; }

    /// <summary>An event which is raised when the image stream bitmap has changed.</summary>
    public extern event TypedEventHandler<MiracastReceiverCursorImageChannel, object> ImageStreamChanged;

    /// <summary>An event which is raised when the position of the cursor image has changed.</summary>
    public extern event TypedEventHandler<MiracastReceiverCursorImageChannel, object> PositionChanged;
  }
}
