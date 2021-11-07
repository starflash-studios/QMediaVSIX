// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ImplicitAnimationCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A collection of animations triggered when a condition is met.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class ImplicitAnimationCollection : 
    CompositionObject,
    IImplicitAnimationCollection,
    IIterable<IKeyValuePair<string, ICompositionAnimationBase>>,
    IMap<string, ICompositionAnimationBase>
  {
    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, ICompositionAnimationBase>> First();

    [MethodImpl]
    public extern ICompositionAnimationBase Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, ICompositionAnimationBase> GetView();

    [MethodImpl]
    public extern bool Insert(string key, ICompositionAnimationBase value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();
  }
}
