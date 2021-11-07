// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SwipeItems
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
  /// <summary>Represents a collection of SwipeItem objects.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISwipeItemsStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Composable(typeof (ISwipeItemsFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  public class SwipeItems : DependencyObject, ISwipeItems, IVector<SwipeItem>, IIterable<SwipeItem>
  {
    /// <summary>Initializes a new instance of the SwipeItems class.</summary>
    [MethodImpl]
    public extern SwipeItems();

    /// <summary>Gets or sets a value that indicates the effect of a swipe interaction.</summary>
    /// <returns>A value of the enumeration that indicates the effect of a swipe interaction. The default is **Reveal**.</returns>
    public extern SwipeMode Mode { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern SwipeItem GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<SwipeItem> GetView();

    [MethodImpl]
    public extern bool IndexOf(SwipeItem value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, SwipeItem value);

    [MethodImpl]
    public extern void InsertAt(uint index, SwipeItem value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(SwipeItem value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] SwipeItem[] items);

    [MethodImpl]
    public extern void ReplaceAll(SwipeItem[] items);

    [MethodImpl]
    public extern IIterator<SwipeItem> First();

    /// <summary>Identifies the Mode dependency property.</summary>
    /// <returns>The identifier for the Mode dependency property.</returns>
    public static extern DependencyProperty ModeProperty { [MethodImpl] get; }
  }
}
