// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlCharacterData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  /// <summary>Provides text manipulation methods that are used by several objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(321798827, 20022, 19958, 177, 200, 12, 230, 47, 216, 139, 38)]
  public interface IXmlCharacterData : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    /// <summary>Gets or sets the node data depending on the node type.</summary>
    /// <returns>The node data.</returns>
    string Data { get; set; }

    /// <summary>Gets the length of the data, in Unicode characters.</summary>
    /// <returns>The length of the data, in Unicode characters.</returns>
    uint Length { get; }

    /// <summary>Retrieves a substring of the full string from the specified range.</summary>
    /// <param name="offset">Specifies the offset, in characters, from the beginning of the string. An offset of zero indicates copying from the start of the data.</param>
    /// <param name="count">Specifies the number of characters to retrieve from the specified offset.</param>
    /// <returns>The returned substring.</returns>
    string SubstringData(uint offset, uint count);

    /// <summary>Appends the supplied string to the existing string data.</summary>
    /// <param name="data">The data to be appended to the existing string.</param>
    void AppendData(string data);

    /// <summary>Inserts a string at the specified offset.</summary>
    /// <param name="offset">The offset, in characters, at which to insert the supplied string data.</param>
    /// <param name="data">The data to be inserted into the existing string.</param>
    void InsertData(uint offset, string data);

    /// <summary>Deletes specified data.</summary>
    /// <param name="offset">The offset, in characters, at which to start deleting the string data.</param>
    /// <param name="count">The number of characters to delete.</param>
    void DeleteData(uint offset, uint count);

    /// <summary>Replaces the specified number of characters with the supplied string.</summary>
    /// <param name="offset">The offset, in characters, at which to start replacing string data.</param>
    /// <param name="count">The number of characters to replace.</param>
    /// <param name="data">The new data that replaces the old string data.</param>
    void ReplaceData(uint offset, uint count, string data);
  }
}
