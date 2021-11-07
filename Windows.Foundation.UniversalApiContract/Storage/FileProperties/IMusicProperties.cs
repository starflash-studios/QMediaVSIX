// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IMusicProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3163204450, 26348, 16794, 188, 93, 202, 101, 164, 203, 70, 218)]
  [ExclusiveTo(typeof (MusicProperties))]
  internal interface IMusicProperties : IStorageItemExtraProperties
  {
    string Album { get; set; }

    string Artist { get; set; }

    IVector<string> Genre { get; }

    uint TrackNumber { get; set; }

    string Title { get; set; }

    uint Rating { get; set; }

    TimeSpan Duration { get; }

    uint Bitrate { get; }

    string AlbumArtist { get; set; }

    IVector<string> Composers { get; }

    IVector<string> Conductors { get; }

    string Subtitle { get; set; }

    IVector<string> Producers { get; }

    string Publisher { get; set; }

    IVector<string> Writers { get; }

    uint Year { get; set; }
  }
}
