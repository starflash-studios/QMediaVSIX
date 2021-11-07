// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IKnownFoldersStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (KnownFolders))]
  [Guid(3306767169, 38722, 20181, 130, 61, 252, 20, 1, 20, 135, 100)]
  internal interface IKnownFoldersStatics3
  {
    [RemoteAsync]
    IAsyncOperation<StorageFolder> GetFolderForUserAsync(
      User user,
      KnownFolderId folderId);
  }
}
