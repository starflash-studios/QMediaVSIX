// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionProjectedShadowCasterCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents a collection of CompositionProjectedShadowCaster objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (ICompositionProjectedShadowCasterCollectionStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  public sealed class CompositionProjectedShadowCasterCollection : 
    CompositionObject,
    ICompositionProjectedShadowCasterCollection,
    IIterable<CompositionProjectedShadowCaster>
  {
    /// <summary>Gets the size (count) of the collection.</summary>
    /// <returns>The number of items in the collection.</returns>
    public extern int Count { [MethodImpl] get; }

    /// <summary>Adds a CompositionProjectedShadowCaster to the collection above the specified item.</summary>
    /// <param name="newCaster">The CompositionProjectedShadowCaster to add to the collection.</param>
    /// <param name="reference">The item to add _newCaster_ above.</param>
    [MethodImpl]
    public extern void InsertAbove(
      CompositionProjectedShadowCaster newCaster,
      CompositionProjectedShadowCaster reference);

    /// <summary>Adds a CompositionProjectedShadowCaster to the bottom of the collection.</summary>
    /// <param name="newCaster">The CompositionProjectedShadowCaster to add to the collection.</param>
    [MethodImpl]
    public extern void InsertAtBottom(CompositionProjectedShadowCaster newCaster);

    /// <summary>Adds a CompositionProjectedShadowCaster to the top of the collection.</summary>
    /// <param name="newCaster">The CompositionProjectedShadowCaster to add to the collection.</param>
    [MethodImpl]
    public extern void InsertAtTop(CompositionProjectedShadowCaster newCaster);

    /// <summary>Adds a CompositionProjectedShadowCaster to the collection below the specified item.</summary>
    /// <param name="newCaster">The CompositionProjectedShadowCaster to add to the collection.</param>
    /// <param name="reference">The item to add _newCaster_ below.</param>
    [MethodImpl]
    public extern void InsertBelow(
      CompositionProjectedShadowCaster newCaster,
      CompositionProjectedShadowCaster reference);

    /// <summary>Removes the specified CompositionProjectedShadowCaster from the collection.</summary>
    /// <param name="caster">The CompositionProjectedShadowCaster to remove from the collection.</param>
    [MethodImpl]
    public extern void Remove(CompositionProjectedShadowCaster caster);

    /// <summary>Removes all items from the collection.</summary>
    [MethodImpl]
    public extern void RemoveAll();

    [MethodImpl]
    public extern IIterator<CompositionProjectedShadowCaster> First();

    /// <summary>Gets the maximum number of shadow casters that will be respected.</summary>
    /// <returns>The maximum number of shadow casters that will be respected.</returns>
    public static extern int MaxRespectedCasters { [MethodImpl] get; }
  }
}
