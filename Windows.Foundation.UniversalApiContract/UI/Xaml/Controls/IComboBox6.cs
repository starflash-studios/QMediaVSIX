// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBox6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ComboBox))]
  [Guid(1638586021, 33275, 24455, 186, 227, 54, 159, 190, 46, 161, 243)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IComboBox6
  {
    bool IsEditable { set; }

    string Text { get; set; }

    Style TextBoxStyle { get; set; }

    object Description { get; set; }

    event TypedEventHandler<ComboBox, ComboBoxTextSubmittedEventArgs> TextSubmitted;
  }
}
