// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IKnownFoldersStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(388163263, 40953, 19233, 190, 213, 144, 236, 177, 58, 25, 46)]
  [ExclusiveTo(typeof (KnownFolders))]
  internal interface IKnownFoldersStatics4
  {
    [RemoteAsync]
    IAsyncOperation<KnownFoldersAccessStatus> RequestAccessAsync(
      KnownFolderId folderId);

    [RemoteAsync]
    IAsyncOperation<KnownFoldersAccessStatus> RequestAccessForUserAsync(
      User user,
      KnownFolderId folderId);

    [RemoteAsync]
    IAsyncOperation<StorageFolder> GetFolderAsync(KnownFolderId folderId);
  }
}
