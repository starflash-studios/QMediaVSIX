// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IImageProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [Guid(1379701796, 64767, 17013, 175, 238, 236, 219, 154, 180, 121, 115)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ImageProperties))]
  internal interface IImageProperties : IStorageItemExtraProperties
  {
    uint Rating { get; set; }

    IVector<string> Keywords { get; }

    DateTime DateTaken { get; set; }

    uint Width { get; }

    uint Height { get; }

    string Title { get; set; }

    IReference<double> Latitude { get; }

    IReference<double> Longitude { get; }

    string CameraManufacturer { get; set; }

    string CameraModel { get; set; }

    PhotoOrientation Orientation { get; }

    IVectorView<string> PeopleNames { get; }
  }
}
