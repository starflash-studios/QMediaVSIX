// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IStorageLibraryContentChangedTriggerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorageLibraryContentChangedTrigger))]
  [Guid(2141133625, 24464, 19986, 145, 78, 167, 216, 224, 187, 251, 24)]
  internal interface IStorageLibraryContentChangedTriggerStatics
  {
    StorageLibraryContentChangedTrigger Create(
      StorageLibrary storageLibrary);

    StorageLibraryContentChangedTrigger CreateFromLibraries(
      IIterable<StorageLibrary> storageLibraries);
  }
}
