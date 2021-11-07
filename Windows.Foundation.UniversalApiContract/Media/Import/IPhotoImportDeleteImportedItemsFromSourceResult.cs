// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportDeleteImportedItemsFromSourceResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4108391160, 33853, 17034, 161, 166, 129, 81, 2, 146, 176, 174)]
  [ExclusiveTo(typeof (PhotoImportDeleteImportedItemsFromSourceResult))]
  internal interface IPhotoImportDeleteImportedItemsFromSourceResult
  {
    PhotoImportSession Session { get; }

    bool HasSucceeded { get; }

    IVectorView<PhotoImportItem> DeletedItems { get; }

    uint PhotosCount { get; }

    ulong PhotosSizeInBytes { get; }

    uint VideosCount { get; }

    ulong VideosSizeInBytes { get; }

    uint SidecarsCount { get; }

    ulong SidecarsSizeInBytes { get; }

    uint SiblingsCount { get; }

    ulong SiblingsSizeInBytes { get; }

    uint TotalCount { get; }

    ulong TotalSizeInBytes { get; }
  }
}
