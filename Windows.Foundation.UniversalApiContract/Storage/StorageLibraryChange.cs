// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageLibraryChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Represents a change to an item in a storage library such as the documents, music, or video library.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class StorageLibraryChange : IStorageLibraryChange
  {
    /// <summary>Gets a StorageLibraryChangeType value that indicates the type of change represented by the object.</summary>
    /// <returns>A StorageLibraryChangeType value that indicates the type of change represented by the object.</returns>
    public extern StorageLibraryChangeType ChangeType { [MethodImpl] get; }

    /// <summary>Gets the full path of the file or folder in the storage library that changed.</summary>
    /// <returns>The full path of the file or folder in the storage library that changed.</returns>
    public extern string Path { [MethodImpl] get; }

    /// <summary>Gets the full path of the item in a storage library before it was moved or renamed.</summary>
    /// <returns>The full path of the file or folder in the storage library before it was moved or renamed.</returns>
    public extern string PreviousPath { [MethodImpl] get; }

    /// <summary>Indicates whether the current StorageFolder matches the specified StorageItemTypes value.</summary>
    /// <param name="type">The enum value that determines the object type to match against.</param>
    /// <returns>True if the StorageFolder matches the specified StorageItemTypes value; otherwise false.</returns>
    [MethodImpl]
    public extern bool IsOfType(StorageItemTypes type);

    /// <summary>Gets the storage item that has changed.</summary>
    /// <returns>When this method completes successfully, it returns an IStorageItem that specifies the item that has changed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> GetStorageItemAsync();
  }
}
