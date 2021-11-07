// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.StorageLibraryChangeTrackerTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Contains the details of a storage library change tracker.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class StorageLibraryChangeTrackerTriggerDetails : 
    IStorageLibraryChangeTrackerTriggerDetails
  {
    /// <summary>Gets the StorageFolder that has been marked as changed by the StorageLibraryChangeTrackerTrigger</summary>
    /// <returns>The StorageFolder that has been changed.</returns>
    public extern StorageFolder Folder { [MethodImpl] get; }

    /// <summary>Gets the StorageLibraryChangeTracker associated with the StorageLibraryChangeTrackerTrigger.</summary>
    /// <returns>The StorageLibraryChangeTracker associated with the StorageLibraryChangeTrackerTrigger.</returns>
    public extern StorageLibraryChangeTracker ChangeTracker { [MethodImpl] get; }
  }
}
