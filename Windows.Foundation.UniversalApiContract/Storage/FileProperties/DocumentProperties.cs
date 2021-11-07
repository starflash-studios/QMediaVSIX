// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.DocumentProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Provides access to the document-related properties of an item (like a file or folder).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DocumentProperties : IDocumentProperties, IStorageItemExtraProperties
  {
    /// <summary>Gets the collection of the document's authors.</summary>
    /// <returns>The name of the document author.</returns>
    public extern IVector<string> Author { [MethodImpl] get; }

    /// <summary>Gets or sets the title of the document.</summary>
    /// <returns>The document title.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of keywords associated with the document.</summary>
    /// <returns>The collection of keywords.</returns>
    public extern IVector<string> Keywords { [MethodImpl] get; }

    /// <summary>Gets or sets the comments associated with the document.</summary>
    /// <returns>The comments.</returns>
    public extern string Comment { [MethodImpl] get; [MethodImpl] set; }

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
