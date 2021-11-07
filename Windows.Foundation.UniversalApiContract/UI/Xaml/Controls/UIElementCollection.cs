// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.UIElementCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an ordered collection of UIElement objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class UIElementCollection : 
    IUIElementCollection,
    IVector<UIElement>,
    IIterable<UIElement>
  {
    /// <summary>Moves the item at the specified index to a new location in the collection.</summary>
    /// <param name="oldIndex">The zero-based index specifying the location of the item to be moved.</param>
    /// <param name="newIndex">The zero-based index specifying the new location of the item.</param>
    [MethodImpl]
    public extern void Move(uint oldIndex, uint newIndex);

    [MethodImpl]
    public extern UIElement GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<UIElement> GetView();

    [MethodImpl]
    public extern bool IndexOf(UIElement value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, UIElement value);

    [MethodImpl]
    public extern void InsertAt(uint index, UIElement value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(UIElement value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] UIElement[] items);

    [MethodImpl]
    public extern void ReplaceAll(UIElement[] items);

    [MethodImpl]
    public extern IIterator<UIElement> First();
  }
}
