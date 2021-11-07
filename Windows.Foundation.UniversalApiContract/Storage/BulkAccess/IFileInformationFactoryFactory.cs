// Decompiled with JetBrains decompiler
// Type: Windows.Storage.BulkAccess.IFileInformationFactoryFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Search;

namespace Windows.Storage.BulkAccess
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2229931645, 58530, 20224, 138, 250, 175, 94, 15, 130, 107, 213)]
  [ExclusiveTo(typeof (FileInformationFactory))]
  internal interface IFileInformationFactoryFactory
  {
    FileInformationFactory CreateWithMode(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode);

    FileInformationFactory CreateWithModeAndSize(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode,
      uint requestedThumbnailSize);

    FileInformationFactory CreateWithModeAndSizeAndOptions(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode,
      uint requestedThumbnailSize,
      ThumbnailOptions thumbnailOptions);

    FileInformationFactory CreateWithModeAndSizeAndOptionsAndFlags(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode,
      uint requestedThumbnailSize,
      ThumbnailOptions thumbnailOptions,
      bool delayLoad);
  }
}
