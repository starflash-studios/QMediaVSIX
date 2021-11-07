// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageItemPropertiesWithProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Provides access to common and content properties on storage items from a particular provider.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2249978779, 25448, 19950, 180, 14, 116, 104, 74, 92, 231, 20)]
  public interface IStorageItemPropertiesWithProvider : IStorageItemProperties
  {
    /// <summary>Gets the StorageProvider object that contains info about the service that stores the current storage item.</summary>
    /// <returns>The StorageProvider object that contains info about the service that stores the current storage item. The item may be stored by the local file system or by a remote service like Microsoft OneDrive.</returns>
    StorageProvider Provider { get; }
  }
}
