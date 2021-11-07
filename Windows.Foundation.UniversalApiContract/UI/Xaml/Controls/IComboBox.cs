// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ComboBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3114848348, 44183, 18417, 165, 244, 63, 159, 77, 75, 17, 108)]
  internal interface IComboBox
  {
    bool IsDropDownOpen { get; set; }

    bool IsEditable { get; }

    bool IsSelectionBoxHighlighted { get; }

    double MaxDropDownHeight { get; set; }

    object SelectionBoxItem { get; }

    DataTemplate SelectionBoxItemTemplate { get; }

    ComboBoxTemplateSettings TemplateSettings { get; }

    event EventHandler<object> DropDownClosed;

    event EventHandler<object> DropDownOpened;
  }
}
