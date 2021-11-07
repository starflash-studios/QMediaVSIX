// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ExclusiveTo(typeof (PhotoImportManager))]
  [Guid(661753917, 41030, 20230, 155, 156, 191, 214, 98, 232, 50, 135)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhotoImportManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<bool> IsSupportedAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<PhotoImportSource>> FindAllSourcesAsync();

    IVectorView<PhotoImportOperation> GetPendingOperations();
  }
}
