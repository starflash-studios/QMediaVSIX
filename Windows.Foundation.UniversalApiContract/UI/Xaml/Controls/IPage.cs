// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Page))]
  [Guid(3300028533, 58945, 17726, 130, 77, 1, 47, 199, 207, 149, 207)]
  [WebHostHidden]
  internal interface IPage
  {
    Frame Frame { get; }

    NavigationCacheMode NavigationCacheMode { get; set; }

    AppBar TopAppBar { get; set; }

    AppBar BottomAppBar { get; set; }
  }
}
