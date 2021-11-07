// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IApplicationData3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (ApplicationData))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3693227252, 10098, 19485, 170, 44, 201, 247, 67, 173, 232, 209)]
  internal interface IApplicationData3
  {
    StorageFolder GetPublisherCacheFolder(string folderName);

    [RemoteAsync]
    IAsyncAction ClearPublisherCacheFolderAsync(string folderName);

    StorageFolder SharedLocalFolder { get; }
  }
}
