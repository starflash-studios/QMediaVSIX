// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaPlayerPresenterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2228712702, 60116, 18775, 180, 43, 34, 49, 88, 202, 13, 231)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlayerPresenter))]
  [WebHostHidden]
  internal interface IMediaPlayerPresenterStatics
  {
    DependencyProperty MediaPlayerProperty { get; }

    DependencyProperty StretchProperty { get; }

    DependencyProperty IsFullWindowProperty { get; }
  }
}
