// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IStorageLibraryChangeTrackerTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (StorageLibraryChangeTrackerTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(514916304, 23173, 18846, 168, 136, 130, 70, 7, 18, 79, 80)]
  internal interface IStorageLibraryChangeTrackerTriggerFactory
  {
    StorageLibraryChangeTrackerTrigger Create(
      StorageLibraryChangeTracker tracker);
  }
}
