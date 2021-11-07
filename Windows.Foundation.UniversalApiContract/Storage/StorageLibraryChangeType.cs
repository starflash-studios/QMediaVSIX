// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageLibraryChangeType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Describes the type of change that occurred to the storage library item.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum StorageLibraryChangeType
  {
    /// <summary>The item was created.</summary>
    Created,
    /// <summary>The item was deleted.</summary>
    Deleted,
    /// <summary>The item was moved or renamed.</summary>
    MovedOrRenamed,
    /// <summary>The contents of the item changed.</summary>
    ContentsChanged,
    /// <summary>The item was moved out of a library.</summary>
    MovedOutOfLibrary,
    /// <summary>The item was moved into a library</summary>
    MovedIntoLibrary,
    /// <summary>The contents have been replaced.</summary>
    ContentsReplaced,
    /// <summary>The item was changed from one where the content can be indexed to one where the content can't be indexed, or vice versa. Content indexing permits rapid searching of data by building a database of selected content.</summary>
    IndexingStatusChanged,
    /// <summary>The encryption applied to this item has changed.</summary>
    EncryptionChanged,
    /// <summary>The change tracking information associated with the item was lost. Call Reset to reestablish continuity with the storage library.</summary>
    ChangeTrackingLost,
  }
}
