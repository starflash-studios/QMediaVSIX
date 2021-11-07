// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IndexableContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.Search
{
  /// <summary>Represents app content and properties that can be added to the ContentIndexer.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class IndexableContent : IIndexableContent
  {
    /// <summary>Initializes a new instance of the IndexableContent class.</summary>
    [MethodImpl]
    public extern IndexableContent();

    /// <summary>Gets or sets the identifier for the content properties in the IndexableContent object. Changes to the actual representation of the item in the index can be made using the ContentIndexer class.</summary>
    /// <returns>The identifier of the content item.</returns>
    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the content properties.</summary>
    /// <returns>The collection of properties, represented as a Map of key-value pairs.</returns>
    public extern IMap<string, object> Properties { [MethodImpl] get; }

    /// <summary>Gets or sets a Stream that provides full-text content. Changes to the actual representation of the item in the index can be made using the ContentIndexer class.</summary>
    /// <returns>The stream used to provide the full-text content for the item.</returns>
    public extern IRandomAccessStream Stream { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the type of content in the Stream.</summary>
    /// <returns>The content type, like StorageFile.ContentType.</returns>
    public extern string StreamContentType { [MethodImpl] get; [MethodImpl] set; }
  }
}
