// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibrary
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(517828867, 3678, 19820, 181, 232, 147, 24, 152, 61, 106, 3)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorageLibrary))]
  internal interface IStorageLibrary
  {
    IAsyncOperation<StorageFolder> RequestAddFolderAsync();

    IAsyncOperation<bool> RequestRemoveFolderAsync(StorageFolder folder);

    IObservableVector<StorageFolder> Folders { get; }

    StorageFolder SaveFolder { get; }

    event TypedEventHandler<StorageLibrary, object> DefinitionChanged;
  }
}
