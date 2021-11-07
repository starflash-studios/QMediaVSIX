// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerFlyoutPresenter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (DatePickerFlyoutPresenter))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(3316799375, 38616, 21964, 151, 238, 63, 136, 252, 133, 228, 121)]
  internal interface IDatePickerFlyoutPresenter2
  {
    bool IsDefaultShadowEnabled { get; set; }
  }
}
