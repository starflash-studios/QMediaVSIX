// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsPresenter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ItemsPresenter))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1543809587, 7667, 18225, 164, 201, 218, 129, 131, 120, 214, 61)]
  internal interface IItemsPresenter2
  {
    object Footer { get; set; }

    DataTemplate FooterTemplate { get; set; }

    TransitionCollection FooterTransitions { get; set; }
  }
}
