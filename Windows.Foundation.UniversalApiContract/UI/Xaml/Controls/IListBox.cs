// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListBox))]
  [WebHostHidden]
  [Guid(3925064191, 36497, 20175, 167, 7, 201, 39, 246, 148, 248, 129)]
  internal interface IListBox
  {
    IVector<object> SelectedItems { get; }

    SelectionMode SelectionMode { get; set; }

    void ScrollIntoView(object item);

    void SelectAll();
  }
}
