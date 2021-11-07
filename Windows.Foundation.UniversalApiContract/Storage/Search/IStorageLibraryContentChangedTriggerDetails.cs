// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageLibraryContentChangedTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ExclusiveTo(typeof (StorageLibraryContentChangedTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(708254071, 43967, 19997, 138, 165, 99, 133, 216, 136, 71, 153)]
  internal interface IStorageLibraryContentChangedTriggerDetails
  {
    StorageFolder Folder { get; }

    StorageItemQueryResult CreateModifiedSinceQuery(DateTime lastQueryTime);
  }
}
