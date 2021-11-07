// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.XmlNodeList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  /// <summary>Describes a collection of nodes.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class XmlNodeList : IXmlNodeList, IVectorView<IXmlNode>, IIterable<IXmlNode>
  {
    /// <summary>Gets the length of the list.</summary>
    /// <returns>The length of the list. The range of valid child node indices is 0 to length-1 inclusive.</returns>
    public extern uint Length { [MethodImpl] get; }

    /// <summary>Returns the item in the list at the specified index.</summary>
    /// <param name="index">The zero-based index of the requested item.</param>
    /// <returns>The requested item. This method returns NULL if the index is not valid.</returns>
    [MethodImpl]
    public extern IXmlNode Item(uint index);

    [MethodImpl]
    public extern IXmlNode GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(IXmlNode value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] IXmlNode[] items);

    [MethodImpl]
    public extern IIterator<IXmlNode> First();
  }
}
