// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewHeaderItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewHeaderItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1758644586, 38576, 20232, 167, 165, 241, 8, 103, 32, 160, 250)]
  internal interface IListViewHeaderItemFactory
  {
    ListViewHeaderItem CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
