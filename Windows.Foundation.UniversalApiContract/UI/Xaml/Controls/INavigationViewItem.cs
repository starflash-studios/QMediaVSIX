// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (NavigationViewItem))]
  [Guid(2249506319, 47030, 18513, 150, 10, 245, 227, 246, 159, 98, 74)]
  [WebHostHidden]
  internal interface INavigationViewItem
  {
    IconElement Icon { get; set; }

    double CompactPaneLength { get; }
  }
}
