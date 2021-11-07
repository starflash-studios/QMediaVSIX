// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.ICustomMapTileDataSourceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Guid(3360127303, 51541, 20258, 148, 68, 161, 216, 215, 68, 175, 17)]
  [ExclusiveTo(typeof (CustomMapTileDataSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICustomMapTileDataSourceFactory
  {
    CustomMapTileDataSource CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
