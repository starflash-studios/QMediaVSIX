// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListBoxItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ListBoxItem))]
  [Guid(1134082260, 41950, 16428, 178, 61, 25, 3, 132, 178, 124, 168)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListBoxItemFactory
  {
    ListBoxItem CreateInstance(object baseInterface, out object innerInterface);
  }
}
