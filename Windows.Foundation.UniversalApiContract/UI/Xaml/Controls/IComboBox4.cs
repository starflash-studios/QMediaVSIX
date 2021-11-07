// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBox4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3080146761, 45148, 18425, 154, 175, 214, 249, 24, 123, 229, 253)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ComboBox))]
  internal interface IComboBox4
  {
    ComboBoxSelectionChangedTrigger SelectionChangedTrigger { get; set; }
  }
}
