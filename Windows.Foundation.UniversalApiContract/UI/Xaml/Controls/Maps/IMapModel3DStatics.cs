// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapModel3DStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapModel3D))]
  [Guid(1211409536, 36438, 19215, 135, 45, 126, 173, 16, 49, 135, 205)]
  internal interface IMapModel3DStatics
  {
    [Overload("CreateFrom3MFAsync")]
    [RemoteAsync]
    IAsyncOperation<MapModel3D> CreateFrom3MFAsync(
      IRandomAccessStreamReference source);

    [Overload("CreateFrom3MFWithShadingOptionAsync")]
    [RemoteAsync]
    IAsyncOperation<MapModel3D> CreateFrom3MFAsync(
      IRandomAccessStreamReference source,
      MapModel3DShadingOption shadingOption);
  }
}
