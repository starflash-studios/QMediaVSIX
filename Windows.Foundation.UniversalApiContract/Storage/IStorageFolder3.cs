// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFolder3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (StorageFolder))]
  [Guid(2673965209, 48609, 16676, 174, 179, 176, 106, 217, 111, 152, 212)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IStorageFolder3
  {
    StorageLibraryChangeTracker TryGetChangeTracker();
  }
}
