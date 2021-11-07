// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IStorageItemExtraProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Saves and retrieves the properties of a storage item.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3309527474, 21709, 17195, 189, 188, 75, 25, 196, 180, 112, 215)]
  public interface IStorageItemExtraProperties
  {
    [RemoteAsync]
    IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync(
      IIterable<string> propertiesToRetrieve);

    [Overload("SavePropertiesAsync")]
    IAsyncAction SavePropertiesAsync(
      [HasVariant] IIterable<IKeyValuePair<string, object>> propertiesToSave);

    /// <summary>Saves all properties associated with the item.</summary>
    /// <returns>An object for managing the asynchronous save operation.</returns>
    [Overload("SavePropertiesAsyncOverloadDefault")]
    [RemoteAsync]
    IAsyncAction SavePropertiesAsync();
  }
}
