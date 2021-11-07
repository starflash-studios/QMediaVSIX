// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageLibraryChangeTrackerTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(499622761, 47011, 19954, 157, 97, 235, 168, 90, 3, 67, 210)]
  [ExclusiveTo(typeof (StorageLibraryChangeTrackerTriggerDetails))]
  internal interface IStorageLibraryChangeTrackerTriggerDetails
  {
    StorageFolder Folder { get; }

    StorageLibraryChangeTracker ChangeTracker { get; }
  }
}
