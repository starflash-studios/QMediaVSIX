// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportStorageMedium
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhotoImportStorageMedium))]
  [Guid(4072255635, 64645, 18559, 135, 194, 88, 214, 117, 208, 91, 7)]
  internal interface IPhotoImportStorageMedium
  {
    string Name { get; }

    string Description { get; }

    string SerialNumber { get; }

    PhotoImportStorageMediumType StorageMediumType { get; }

    PhotoImportAccessMode SupportedAccessMode { get; }

    ulong CapacityInBytes { get; }

    ulong AvailableSpaceInBytes { get; }

    void Refresh();
  }
}
