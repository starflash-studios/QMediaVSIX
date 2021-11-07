// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IHttpMapTileDataSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (HttpMapTileDataSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2634271580, 64889, 18325, 135, 190, 126, 84, 202, 11, 55, 208)]
  internal interface IHttpMapTileDataSource
  {
    string UriFormatString { get; set; }

    IMap<string, string> AdditionalRequestHeaders { get; }

    bool AllowCaching { get; set; }

    event TypedEventHandler<HttpMapTileDataSource, MapTileUriRequestedEventArgs> UriRequested;
  }
}
