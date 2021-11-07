// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemPhotoProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (SystemPhotoProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1194654781, 43809, 17444, 183, 53, 244, 53, 58, 86, 200, 252)]
  internal interface ISystemPhotoProperties
  {
    string CameraManufacturer { get; }

    string CameraModel { get; }

    string DateTaken { get; }

    string Orientation { get; }

    string PeopleNames { get; }
  }
}
