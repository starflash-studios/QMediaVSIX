// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionProjectedShadowReceiverUnorderedCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents an unordered collection of CompositionProjectedShadowReceiver objects.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class CompositionProjectedShadowReceiverUnorderedCollection : 
    CompositionObject,
    ICompositionProjectedShadowReceiverUnorderedCollection,
    IIterable<CompositionProjectedShadowReceiver>
  {
    /// <summary>Adds the specified CompositionProjectedShadowReceiver to the collection.</summary>
    /// <param name="value">The item to add to the collection.</param>
    [MethodImpl]
    public extern void Add(CompositionProjectedShadowReceiver value);

    /// <summary>Gets the size (count) of the collection.</summary>
    /// <returns>The number of items in the collection.</returns>
    public extern int Count { [MethodImpl] get; }

    /// <summary>Removes the specified CompositionProjectedShadowReceiver from the collection.</summary>
    /// <param name="value">The CompositionProjectedShadowReceiver to remove from the collection.</param>
    [MethodImpl]
    public extern void Remove(CompositionProjectedShadowReceiver value);

    /// <summary>Removes all items from the collection.</summary>
    [MethodImpl]
    public extern void RemoveAll();

    [MethodImpl]
    public extern IIterator<CompositionProjectedShadowReceiver> First();
  }
}
