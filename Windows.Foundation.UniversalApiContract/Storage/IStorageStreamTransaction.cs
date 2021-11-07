// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageStreamTransaction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4135383907, 42301, 19860, 174, 44, 103, 35, 45, 147, 172, 221)]
  [ExclusiveTo(typeof (StorageStreamTransaction))]
  internal interface IStorageStreamTransaction : IClosable
  {
    IRandomAccessStream Stream { get; }

    [RemoteAsync]
    IAsyncAction CommitAsync();
  }
}
