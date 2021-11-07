// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibraryStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(4289760732, 64117, 18069, 185, 209, 127, 129, 249, 120, 50, 227)]
  [ExclusiveTo(typeof (StorageLibrary))]
  internal interface IStorageLibraryStatics2
  {
    [RemoteAsync]
    IAsyncOperation<StorageLibrary> GetLibraryForUserAsync(
      User user,
      KnownLibraryId libraryId);
  }
}
