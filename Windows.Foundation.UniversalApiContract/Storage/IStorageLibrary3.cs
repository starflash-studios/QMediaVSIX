// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibrary3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (StorageLibrary))]
  [Guid(2317882001, 8532, 16897, 129, 19, 210, 192, 92, 225, 173, 35)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IStorageLibrary3
  {
    [RemoteAsync]
    IAsyncOperation<bool> AreFolderSuggestionsAvailableAsync();
  }
}
