// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.ILocalMapTileDataSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (LocalMapTileDataSource))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1633834933, 37128, 20242, 139, 244, 187, 60, 143, 98, 116, 229)]
  internal interface ILocalMapTileDataSource
  {
    string UriFormatString { get; set; }

    event TypedEventHandler<LocalMapTileDataSource, MapTileUriRequestedEventArgs> UriRequested;
  }
}
