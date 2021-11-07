// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ISharedStorageAccessManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (SharedStorageAccessManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3323144922, 13489, 18505, 189, 95, 208, 159, 238, 49, 88, 197)]
  internal interface ISharedStorageAccessManagerStatics
  {
    string AddFile(IStorageFile file);

    [RemoteAsync]
    IAsyncOperation<StorageFile> RedeemTokenForFileAsync(string token);

    void RemoveFile(string token);
  }
}
