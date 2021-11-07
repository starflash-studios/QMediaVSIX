// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaTransportControlsStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MediaTransportControls))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1608537410, 2368, 4583, 147, 174, 146, 54, 31, 0, 38, 113)]
  internal interface IMediaTransportControlsStatics3
  {
    DependencyProperty ShowAndHideAutomaticallyProperty { get; }

    DependencyProperty IsRepeatEnabledProperty { get; }

    DependencyProperty IsRepeatButtonVisibleProperty { get; }
  }
}
