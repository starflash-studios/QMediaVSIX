// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibraryChangeTrackerOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (StorageLibraryChangeTrackerOptions))]
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  [Guid(3142761684, 6765, 22976, 173, 42, 130, 58, 32, 83, 36, 131)]
  internal interface IStorageLibraryChangeTrackerOptions
  {
    bool TrackChangeDetails { get; set; }
  }
}
