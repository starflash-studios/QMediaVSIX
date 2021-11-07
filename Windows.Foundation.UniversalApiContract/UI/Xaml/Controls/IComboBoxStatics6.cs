// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBoxStatics6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ComboBox))]
  [WebHostHidden]
  [Guid(1366067424, 60523, 21676, 140, 87, 94, 192, 128, 238, 5, 200)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IComboBoxStatics6
  {
    DependencyProperty IsEditableProperty { get; }

    DependencyProperty TextProperty { get; }

    DependencyProperty TextBoxStyleProperty { get; }

    DependencyProperty DescriptionProperty { get; }
  }
}
