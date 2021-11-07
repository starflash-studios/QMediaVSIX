// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageLibraryChangeTracker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Provides APIs that you can use to manage change tracking for any library in the system such as documents, music, or videos.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class StorageLibraryChangeTracker : 
    IStorageLibraryChangeTracker,
    IStorageLibraryChangeTracker2
  {
    /// <summary>Retrieves an StorageLibraryChangeReader that enables the app to iterate through the list of changes and mark changes as accepted.</summary>
    /// <returns>The returned change reader.</returns>
    [MethodImpl]
    public extern StorageLibraryChangeReader GetChangeReader();

    /// <summary>Enables change tracking for the storage library.</summary>
    [MethodImpl]
    public extern void Enable();

    /// <summary>Resets change tracking for the storage library, deleting existing change tracking data.</summary>
    [MethodImpl]
    public extern void Reset();

    [Overload("EnableWithOptions")]
    [MethodImpl]
    public extern void Enable(StorageLibraryChangeTrackerOptions options);

    [MethodImpl]
    public extern void Disable();
  }
}
