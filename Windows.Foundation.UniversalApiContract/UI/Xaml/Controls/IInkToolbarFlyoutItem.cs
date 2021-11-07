// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarFlyoutItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2461435782, 14318, 18709, 158, 137, 225, 135, 86, 74, 136, 154)]
  [ExclusiveTo(typeof (InkToolbarFlyoutItem))]
  internal interface IInkToolbarFlyoutItem
  {
    InkToolbarFlyoutItemKind Kind { get; set; }

    bool IsChecked { get; set; }

    event TypedEventHandler<InkToolbarFlyoutItem, object> Checked;

    event TypedEventHandler<InkToolbarFlyoutItem, object> Unchecked;
  }
}
