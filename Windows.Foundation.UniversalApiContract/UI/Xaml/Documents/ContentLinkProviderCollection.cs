// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ContentLinkProviderCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Represents a collection of ContentLinkProvider objects that can be individually accessed by index.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class ContentLinkProviderCollection : 
    IContentLinkProviderCollection,
    IVector<ContentLinkProvider>,
    IIterable<ContentLinkProvider>
  {
    /// <summary>Initializes a new instance of the ContentLinkProviderCollection class.</summary>
    [MethodImpl]
    public extern ContentLinkProviderCollection();

    [MethodImpl]
    public extern ContentLinkProvider GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<ContentLinkProvider> GetView();

    [MethodImpl]
    public extern bool IndexOf(ContentLinkProvider value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, ContentLinkProvider value);

    [MethodImpl]
    public extern void InsertAt(uint index, ContentLinkProvider value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(ContentLinkProvider value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] ContentLinkProvider[] items);

    [MethodImpl]
    public extern void ReplaceAll(ContentLinkProvider[] items);

    [MethodImpl]
    public extern IIterator<ContentLinkProvider> First();
  }
}
