// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlayerSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.Media.Playback
{
  /// <summary>Provides access to a ICompositionSurface that is shared between a MediaPlayer and a Compositor to enable the rendering of **MediaPlayer** content using the Windows.UI.Composition APIs without requiring the use of the XAML framework.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaPlayerSurface : IMediaPlayerSurface, IClosable
  {
    /// <summary>Gets the ICompositionSurface for rendering MediaPlayer content.</summary>
    /// <returns>The ICompositionSurface for rendering MediaPlayer content.</returns>
    public extern ICompositionSurface CompositionSurface { [MethodImpl] get; }

    /// <summary>Gets the Compositor with which the surface will be used.</summary>
    /// <returns>The Compositor with which the surface will be used.</returns>
    public extern Compositor Compositor { [MethodImpl] get; }

    /// <summary>Gets the MediaPlayer associated with the MediaPlayerSurface.</summary>
    /// <returns>The MediaPlayer associated with the MediaPlayerSurface.</returns>
    public extern MediaPlayer MediaPlayer { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
