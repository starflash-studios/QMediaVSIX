// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewListFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4209939777, 50111, 18367, 185, 4, 97, 85, 244, 223, 107, 79)]
  [ExclusiveTo(typeof (NavigationViewList))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface INavigationViewListFactory
  {
    NavigationViewList CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
