// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPageOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(587963576, 13337, 17158, 170, 190, 74, 142, 104, 13, 54, 39)]
  [ExclusiveTo(typeof (Page))]
  internal interface IPageOverrides
  {
    void OnNavigatedFrom(NavigationEventArgs e);

    void OnNavigatedTo(NavigationEventArgs e);

    void OnNavigatingFrom(NavigatingCancelEventArgs e);
  }
}
