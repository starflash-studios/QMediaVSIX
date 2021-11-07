// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemMusicProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>A helper object that provides indexing names for Windows music file properties.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SystemMusicProperties : ISystemMusicProperties
  {
    /// <summary>Gets the name of the System.Music.AlbumArtist property (one of the Windows music file properties.</summary>
    /// <returns>The name of the System.Music.AlbumArtist file property.</returns>
    public extern string AlbumArtist { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Music.AlbumTitle property (one of the Windows music file properties.</summary>
    /// <returns>The name of the System.Music.AlbumTitle file property.</returns>
    public extern string AlbumTitle { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Music.Artist property (one of the Windows music file properties.</summary>
    /// <returns>The name of the System.Music.Artist file property.</returns>
    public extern string Artist { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Music.Composer property (one of the Windows music file properties.</summary>
    /// <returns>The name of the System.Music.Composer file property.</returns>
    public extern string Composer { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Music.Conductor property (one of the Windows music file properties.</summary>
    /// <returns>The name of the System.Music.Conductor file property.</returns>
    public extern string Conductor { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Music.DisplayArtist property (one of the Windows music file properties.</summary>
    /// <returns>The name of the System.Music.DisplayArtist file property.</returns>
    public extern string DisplayArtist { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Music.Genre property (one of the Windows music file properties.</summary>
    /// <returns>The name of the System.Music.Genre file property.</returns>
    public extern string Genre { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Music.TrackNumber property (one of the Windows music file properties.</summary>
    /// <returns>The name of the System.Music.TrackNumber file property.</returns>
    public extern string TrackNumber { [MethodImpl] get; }
  }
}
