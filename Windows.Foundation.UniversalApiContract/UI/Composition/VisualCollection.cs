// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.VisualCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents a collection of visual instances.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  public sealed class VisualCollection : CompositionObject, IVisualCollection, IIterable<Visual>
  {
    /// <summary>Gets the number of visual instances in the collection.</summary>
    /// <returns>The number of visual instances in the collection.</returns>
    public extern int Count { [MethodImpl] get; }

    /// <summary>Inserts a visual above the specified sibling visual in the visual collection.</summary>
    /// <param name="newChild">The new visual to insert.</param>
    /// <param name="sibling">The sibling to insert the visual above.</param>
    [MethodImpl]
    public extern void InsertAbove(Visual newChild, Visual sibling);

    /// <summary>Inserts a new visual at the bottom of the visual collection.</summary>
    /// <param name="newChild">The new visual to insert.</param>
    [MethodImpl]
    public extern void InsertAtBottom(Visual newChild);

    /// <summary>Inserts a new visual at the top of the visual collection.</summary>
    /// <param name="newChild">The new visual to insert.</param>
    [MethodImpl]
    public extern void InsertAtTop(Visual newChild);

    /// <summary>Insert a new visual below the specified visual in the visual collection.</summary>
    /// <param name="newChild">The new visual to insert.</param>
    /// <param name="sibling">The sibling visual to insert the new visual below.</param>
    [MethodImpl]
    public extern void InsertBelow(Visual newChild, Visual sibling);

    /// <summary>Removes the specified visual instance from the collection.</summary>
    /// <param name="child">The specified visual instance from the collection.</param>
    [MethodImpl]
    public extern void Remove(Visual child);

    /// <summary>Removes all of the visual instances from the collection.</summary>
    [MethodImpl]
    public extern void RemoveAll();

    [MethodImpl]
    public extern IIterator<Visual> First();
  }
}
