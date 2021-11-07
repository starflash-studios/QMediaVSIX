// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameSourceGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Represents a group of media frame sources that can be used simultaneously by a MediaCapture.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaFrameSourceGroupStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  public sealed class MediaFrameSourceGroup : IMediaFrameSourceGroup
  {
    /// <summary>Gets a unique identifier for the media frame source group.</summary>
    /// <returns>A unique identifier for the media frame source group.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the human-readable name for the media frame source group.</summary>
    /// <returns>The human-readable name for the media frame source group.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets a list of MediaFrameSourceInfo objects that describe each media frame source in the group.</summary>
    /// <returns>An asynchronous action that returns a list of MediaFrameSourceInfo upon successful completion.</returns>
    public extern IVectorView<MediaFrameSourceInfo> SourceInfos { [MethodImpl] get; }

    /// <summary>Asynchronously retrieves a list of the available media frame source groups on the current device.</summary>
    /// <returns>An asynchronous operation that returns a list of MediaFrameSourceGroup objects upon completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<MediaFrameSourceGroup>> FindAllAsync();

    /// <summary>Asynchronously gets the media frame source group with the specified ID.</summary>
    /// <param name="id">The unique identifier of a media frame source group.</param>
    /// <returns>An asynchronous operation that returns a MediaFrameSourceGroup upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaFrameSourceGroup> FromIdAsync(
      string id);

    /// <summary>Gets a device selector string that can be used to initialize a DeviceWatcher, which allows you receive notifications when the set of available media frame source groups changes.</summary>
    /// <returns>The device selector string for a media frame source group.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
