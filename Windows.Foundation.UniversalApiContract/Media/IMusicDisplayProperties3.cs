// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMusicDisplayProperties3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(1303714497, 1665, 20108, 148, 1, 184, 21, 157, 158, 239, 199)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MusicDisplayProperties))]
  internal interface IMusicDisplayProperties3
  {
    uint AlbumTrackCount { get; set; }
  }
}
