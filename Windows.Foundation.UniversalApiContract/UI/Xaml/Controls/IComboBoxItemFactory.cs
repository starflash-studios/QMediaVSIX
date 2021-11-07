// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBoxItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ComboBoxItem))]
  [Guid(2415913063, 55628, 20103, 143, 196, 110, 188, 214, 60, 90, 194)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IComboBoxItemFactory
  {
    ComboBoxItem CreateInstance(object baseInterface, out object innerInterface);
  }
}
