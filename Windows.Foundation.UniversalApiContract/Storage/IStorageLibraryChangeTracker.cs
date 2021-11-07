// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibraryChangeTracker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(2652205846, 24691, 17654, 150, 129, 116, 146, 209, 40, 108, 144)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (StorageLibraryChangeTracker))]
  internal interface IStorageLibraryChangeTracker
  {
    StorageLibraryChangeReader GetChangeReader();

    void Enable();

    void Reset();
  }
}
