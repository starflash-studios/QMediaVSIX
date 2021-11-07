// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileUriRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Guid(390079285, 12583, 17848, 135, 167, 153, 248, 125, 78, 39, 69)]
  [ExclusiveTo(typeof (MapTileUriRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapTileUriRequest
  {
    Uri Uri { get; set; }

    MapTileUriRequestDeferral GetDeferral();
  }
}
