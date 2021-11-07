// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePickerFlyoutPresenter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2705021800, 32489, 23031, 170, 214, 101, 50, 168, 168, 195, 191)]
  [ExclusiveTo(typeof (TimePickerFlyoutPresenter))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  internal interface ITimePickerFlyoutPresenter2
  {
    bool IsDefaultShadowEnabled { get; set; }
  }
}
