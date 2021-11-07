// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (ListViewItemPresenter))]
  [Guid(4124857494, 57634, 19543, 166, 37, 172, 75, 8, 251, 45, 76)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IListViewItemPresenter2
  {
    Brush SelectedPressedBackground { get; set; }

    Brush PressedBackground { get; set; }

    Brush CheckBoxBrush { get; set; }

    Brush FocusSecondaryBorderBrush { get; set; }

    ListViewItemPresenterCheckMode CheckMode { get; set; }

    Brush PointerOverForeground { get; set; }
  }
}
