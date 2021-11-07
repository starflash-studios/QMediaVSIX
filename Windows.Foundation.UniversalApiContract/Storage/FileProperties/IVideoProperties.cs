// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IVideoProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [Guid(1905976583, 26846, 19896, 151, 222, 73, 153, 140, 5, 159, 47)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoProperties))]
  internal interface IVideoProperties : IStorageItemExtraProperties
  {
    uint Rating { get; set; }

    IVector<string> Keywords { get; }

    uint Width { get; }

    uint Height { get; }

    TimeSpan Duration { get; }

    IReference<double> Latitude { get; }

    IReference<double> Longitude { get; }

    string Title { get; set; }

    string Subtitle { get; set; }

    IVector<string> Producers { get; }

    string Publisher { get; set; }

    IVector<string> Writers { get; }

    uint Year { get; set; }

    uint Bitrate { get; }

    IVector<string> Directors { get; }

    VideoOrientation Orientation { get; }
  }
}
