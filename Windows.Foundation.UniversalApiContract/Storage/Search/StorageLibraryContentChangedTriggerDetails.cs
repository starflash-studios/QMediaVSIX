// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.StorageLibraryContentChangedTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Contains the details of a storage library content change tracker.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageLibraryContentChangedTriggerDetails : 
    IStorageLibraryContentChangedTriggerDetails
  {
    /// <summary>Gets the StorageFolder that has been changed.</summary>
    /// <returns>The StorageFolder that has been changed.</returns>
    public extern StorageFolder Folder { [MethodImpl] get; }

    [MethodImpl]
    public extern StorageItemQueryResult CreateModifiedSinceQuery(
      DateTime lastQueryTime);
  }
}
