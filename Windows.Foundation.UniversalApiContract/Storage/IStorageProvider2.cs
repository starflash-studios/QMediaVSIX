// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageProvider2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (StorageProvider))]
  [Guid(17635607, 13316, 16715, 159, 215, 205, 68, 71, 46, 170, 57)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IStorageProvider2 : IStorageProvider
  {
    [RemoteAsync]
    IAsyncOperation<bool> IsPropertySupportedForPartialFileAsync(
      string propertyCanonicalName);
  }
}
