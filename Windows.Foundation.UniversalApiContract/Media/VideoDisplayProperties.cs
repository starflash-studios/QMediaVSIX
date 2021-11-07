// Decompiled with JetBrains decompiler
// Type: Windows.Media.VideoDisplayProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Provides properties for video information that is displayed by SystemMediaTransportControlsDisplayUpdater class.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VideoDisplayProperties : IVideoDisplayProperties, IVideoDisplayProperties2
  {
    /// <summary>Gets or sets the title of the video.</summary>
    /// <returns>The title of the video.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the subtitle of the video.</summary>
    /// <returns>The subtitle of the video.</returns>
    public extern string Subtitle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a modifiable list of strings representing genre names.</summary>
    /// <returns>A modifiable list of strings representing genre names.</returns>
    public extern IVector<string> Genres { [MethodImpl] get; }
  }
}
