// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Import
{
  [Guid(2858652014, 60635, 20222, 148, 198, 95, 92, 175, 227, 76, 251)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhotoImportSession))]
  internal interface IPhotoImportSession : IClosable
  {
    PhotoImportSource Source { get; }

    Guid SessionId { get; }

    IStorageFolder DestinationFolder { set; get; }

    bool AppendSessionDateToDestinationFolder { set; get; }

    PhotoImportSubfolderCreationMode SubfolderCreationMode { set; get; }

    string DestinationFileNamePrefix { set; get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<PhotoImportFindItemsResult, uint> FindItemsAsync(
      PhotoImportContentTypeFilter contentTypeFilter,
      PhotoImportItemSelectionMode itemSelectionMode);
  }
}
