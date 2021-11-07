// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibraryChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(9964323, 11234, 18697, 170, 72, 21, 159, 82, 3, 165, 30)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (StorageLibraryChange))]
  internal interface IStorageLibraryChange
  {
    StorageLibraryChangeType ChangeType { get; }

    string Path { get; }

    string PreviousPath { get; }

    bool IsOfType(StorageItemTypes type);

    [RemoteAsync]
    IAsyncOperation<IStorageItem> GetStorageItemAsync();
  }
}
