// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageItem2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Manipulates storage items (files and folders) and their contents, and provides information about them.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1408837330, 2108, 17027, 180, 91, 129, 192, 7, 35, 126, 68)]
  public interface IStorageItem2 : IStorageItem
  {
    /// <summary>Gets the parent folder of the current storage item.</summary>
    /// <returns>When this method completes, it returns the parent folder as a StorageFolder.</returns>
    [RemoteAsync]
    IAsyncOperation<StorageFolder> GetParentAsync();

    /// <summary>Indicates whether the current item is the same as the specified item.</summary>
    /// <param name="item">The IStorageItem object that represents a storage item to compare against.</param>
    /// <returns>Returns **true** if the current storage item is the same as the specified storage item; otherwise **false**.</returns>
    bool IsEqual(IStorageItem item);
  }
}
