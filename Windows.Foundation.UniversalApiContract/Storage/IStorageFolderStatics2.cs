// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFolderStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (StorageFolder))]
  [Guid(3026546115, 29138, 18045, 139, 41, 55, 31, 15, 98, 191, 111)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IStorageFolderStatics2
  {
    [RemoteAsync]
    IAsyncOperation<StorageFolder> GetFolderFromPathForUserAsync(
      User user,
      string path);
  }
}
