// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibrary2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (StorageLibrary))]
  [Guid(1527571272, 64691, 16433, 175, 176, 166, 141, 123, 212, 69, 52)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IStorageLibrary2
  {
    StorageLibraryChangeTracker ChangeTracker { get; }
  }
}
