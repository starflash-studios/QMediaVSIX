// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaPlayerElementStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(511459360, 44119, 17117, 173, 28, 62, 188, 45, 127, 8, 186)]
  [ExclusiveTo(typeof (MediaPlayerElement))]
  [WebHostHidden]
  internal interface IMediaPlayerElementStatics
  {
    DependencyProperty SourceProperty { get; }

    DependencyProperty AreTransportControlsEnabledProperty { get; }

    DependencyProperty PosterSourceProperty { get; }

    DependencyProperty StretchProperty { get; }

    DependencyProperty AutoPlayProperty { get; }

    DependencyProperty IsFullWindowProperty { get; }

    DependencyProperty MediaPlayerProperty { get; }
  }
}
