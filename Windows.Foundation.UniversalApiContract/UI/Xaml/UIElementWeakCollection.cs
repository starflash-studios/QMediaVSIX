// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.UIElementWeakCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents a collection of weak references to UIElement objects.</summary>
  [Composable(typeof (IUIElementWeakCollectionFactory), CompositionType.Public, 524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  public class UIElementWeakCollection : 
    IUIElementWeakCollection,
    IVector<UIElement>,
    IIterable<UIElement>
  {
    /// <summary>Initializes a new instance of the UIElementWeakCollection class.</summary>
    [MethodImpl]
    public extern UIElementWeakCollection();

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
