// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibraryLastChangeIdStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  [ExclusiveTo(typeof (StorageLibraryLastChangeId))]
  [Guid(2175045928, 11427, 21257, 176, 209, 207, 7, 136, 228, 7, 98)]
  internal interface IStorageLibraryLastChangeIdStatics
  {
    ulong Unknown { get; }
  }
}
