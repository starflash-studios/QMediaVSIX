// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.VisualUnorderedCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>An unordered collection of visuals.</summary>
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VisualUnorderedCollection : 
    CompositionObject,
    IVisualUnorderedCollection,
    IIterable<Visual>
  {
    /// <summary>The number of visuals in the collection.</summary>
    /// <returns>The nubmer of visuals in the collection.</returns>
    public extern int Count { [MethodImpl] get; }

    /// <summary>Adds a visual to the collection.</summary>
    /// <param name="newVisual">The visual to add to the collection.</param>
    [MethodImpl]
    public extern void Add(Visual newVisual);

    /// <summary>Removes a visual from the collection.</summary>
    /// <param name="visual">Removes a visual from the collection.</param>
    [MethodImpl]
    public extern void Remove(Visual visual);

    /// <summary>Removes all visuals from the collection.</summary>
    [MethodImpl]
    public extern void RemoveAll();

    [MethodImpl]
    public extern IIterator<Visual> First();
  }
}
