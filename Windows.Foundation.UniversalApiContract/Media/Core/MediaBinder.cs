// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaBinder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Enables deferred binding of media content associated with a MediaSource.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Activatable(131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaBinder : IMediaBinder
  {
    /// <summary>Initializes a new instance of the MediaBinder class.</summary>
    [MethodImpl]
    public extern MediaBinder();

    /// <summary>Occurs when a media player is ready for the media content to be bound to a MediaSource. Use the handler for this to set the media content for the source by calling SetStream, SetStreamReference, or SetUri.</summary>
    public extern event TypedEventHandler<MediaBinder, MediaBindingEventArgs> Binding;

    /// <summary>Gets or sets an app-specified string that is used to identify the media content that the app should bind when the Binding event is raised.</summary>
    /// <returns>An app-specified string that is used to identify the specific media content that the app should bind.</returns>
    public extern string Token { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the MediaSource object associated with the MediaBinder.</summary>
    /// <returns>The MediaSource object associated with the MediaBinder.</returns>
    public extern MediaSource Source { [MethodImpl] get; }
  }
}
