// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBox2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ComboBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3926704017, 51766, 20397, 151, 42, 46, 83, 166, 113, 139, 159)]
  internal interface IComboBox2
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    string PlaceholderText { get; set; }
  }
}
