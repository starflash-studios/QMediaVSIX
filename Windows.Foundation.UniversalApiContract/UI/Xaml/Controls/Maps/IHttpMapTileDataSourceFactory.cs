// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IHttpMapTileDataSourceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (HttpMapTileDataSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1404350727, 34012, 17041, 137, 248, 109, 11, 182, 18, 160, 85)]
  internal interface IHttpMapTileDataSourceFactory
  {
    HttpMapTileDataSource CreateInstance(
      object baseInterface,
      out object innerInterface);

    HttpMapTileDataSource CreateInstanceWithUriFormatString(
      string uriFormatString,
      object baseInterface,
      out object innerInterface);
  }
}
