// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMusicDisplayProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(1807682649, 53408, 19750, 146, 160, 249, 120, 225, 209, 142, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MusicDisplayProperties))]
  internal interface IMusicDisplayProperties
  {
    string Title { get; set; }

    string AlbumArtist { get; set; }

    string Artist { get; set; }
  }
}
