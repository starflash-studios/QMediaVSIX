// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.ICustomMapTileDataSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(1708800074, 11697, 19425, 177, 85, 61, 12, 158, 207, 71, 153)]
  [ExclusiveTo(typeof (CustomMapTileDataSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ICustomMapTileDataSource
  {
    event TypedEventHandler<CustomMapTileDataSource, MapTileBitmapRequestedEventArgs> BitmapRequested;
  }
}
