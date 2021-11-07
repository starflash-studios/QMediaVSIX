// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.BasicProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Provides access to the basic properties, like the size of the item or the date the item was last modified, of the item (like a file or folder).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100794368)]
  public sealed class BasicProperties : IBasicProperties, IStorageItemExtraProperties
  {
    /// <summary>Gets the size of the file in bytes.</summary>
    /// <returns>The size of the file in bytes.</returns>
    public extern ulong Size { [MethodImpl] get; }

    /// <summary>Gets the timestamp of the last time the file was modified.</summary>
    /// <returns>The timestamp.</returns>
    public extern DateTime DateModified { [MethodImpl] get; }

    /// <summary>Gets the most relevant date for the item.</summary>
    /// <returns>The item's date.</returns>
    public extern DateTime ItemDate { [MethodImpl] get; }

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
    [Overload("SavePropertiesAsyncOverloadDefault")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SavePropertiesAsync();
  }
}
