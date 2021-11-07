// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerFlyoutItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2644230793, 210, 19116, 156, 133, 215, 79, 6, 54, 120, 135)]
  [ExclusiveTo(typeof (DatePickerFlyoutItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDatePickerFlyoutItem
  {
    string PrimaryText { get; set; }

    string SecondaryText { get; set; }
  }
}
