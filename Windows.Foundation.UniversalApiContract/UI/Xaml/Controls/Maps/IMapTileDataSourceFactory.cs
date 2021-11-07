// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileDataSourceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2744258493, 58438, 17992, 167, 77, 253, 44, 93, 85, 124, 6)]
  [ExclusiveTo(typeof (MapTileDataSource))]
  [WebHostHidden]
  internal interface IMapTileDataSourceFactory
  {
    MapTileDataSource CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
