// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.StorageItemContentProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Provides access to the content-related properties of an item (like a file or folder).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageItemContentProperties : 
    IStorageItemContentProperties,
    IStorageItemExtraProperties
  {
    /// <summary>Retrieves the music properties of the item (like a file of folder).</summary>
    /// <returns>When this method completes successfully, it returns a MusicProperties object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MusicProperties> GetMusicPropertiesAsync();

    /// <summary>Retrieves the video properties of the item (like a file of folder).</summary>
    /// <returns>When this method completes successfully, it returns a VideoProperties object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VideoProperties> GetVideoPropertiesAsync();

    /// <summary>Retrieves the image properties of the item (like a file of folder).</summary>
    /// <returns>When this method completes successfully, it returns an ImageProperties object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ImageProperties> GetImagePropertiesAsync();

    /// <summary>Retrieves the document properties of the item (like a file of folder).</summary>
    /// <returns>When this method completes successfully, it returns a DocumentProperties object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DocumentProperties> GetDocumentPropertiesAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync(
      IIterable<string> propertiesToRetrieve);

    [Overload("SavePropertiesAsync")]
    [MethodImpl]
    public extern IAsyncAction SavePropertiesAsync(
      [HasVariant] IIterable<IKeyValuePair<string, object>> propertiesToSave);

    /// <summary>Saves all properties associated with the item.</summary>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [Overload("SavePropertiesAsyncOverloadDefault")]
    [MethodImpl]
    public extern IAsyncAction SavePropertiesAsync();
  }
}
