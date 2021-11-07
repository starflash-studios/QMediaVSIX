// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFileStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [Guid(1551280001, 8494, 19193, 143, 4, 116, 12, 174, 16, 137, 116)]
  [ExclusiveTo(typeof (StorageFile))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IStorageFileStatics2
  {
    [RemoteAsync]
    IAsyncOperation<StorageFile> GetFileFromPathForUserAsync(
      User user,
      string path);
  }
}
