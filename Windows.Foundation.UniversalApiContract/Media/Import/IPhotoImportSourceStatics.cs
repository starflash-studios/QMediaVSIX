// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Import
{
  [Guid(86566278, 13016, 18044, 140, 238, 35, 161, 178, 244, 62, 133)]
  [ExclusiveTo(typeof (PhotoImportSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhotoImportSourceStatics
  {
    [RemoteAsync]
    IAsyncOperation<PhotoImportSource> FromIdAsync(string sourceId);

    [RemoteAsync]
    IAsyncOperation<PhotoImportSource> FromFolderAsync(
      IStorageFolder sourceRootFolder);
  }
}
