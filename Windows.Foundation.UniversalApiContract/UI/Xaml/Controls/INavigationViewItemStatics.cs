// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewItemStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (NavigationViewItem))]
  [WebHostHidden]
  [Guid(2151415937, 64933, 19344, 170, 206, 63, 35, 6, 219, 229, 196)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface INavigationViewItemStatics
  {
    DependencyProperty IconProperty { get; }

    DependencyProperty CompactPaneLengthProperty { get; }
  }
}
