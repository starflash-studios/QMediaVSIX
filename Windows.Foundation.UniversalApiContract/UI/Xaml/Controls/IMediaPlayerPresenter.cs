// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaPlayerPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (MediaPlayerPresenter))]
  [WebHostHidden]
  [Guid(2007573286, 3163, 16892, 191, 73, 21, 246, 195, 82, 75, 107)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlayerPresenter
  {
    MediaPlayer MediaPlayer { get; set; }

    Stretch Stretch { get; set; }

    bool IsFullWindow { get; set; }
  }
}
