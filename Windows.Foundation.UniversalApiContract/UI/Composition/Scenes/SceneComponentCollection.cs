// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneComponentCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents a collection of SceneComponent objects that can be individually accessed by index.</summary>
  [WebHostHidden]
  [DualApiPartition(version = 167772166)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SceneComponentCollection : 
    SceneObject,
    ISceneComponentCollection,
    IVector<SceneComponent>,
    IIterable<SceneComponent>
  {
    [MethodImpl]
    public extern SceneComponent GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<SceneComponent> GetView();

    [MethodImpl]
    public extern bool IndexOf(SceneComponent value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, SceneComponent value);

    [MethodImpl]
    public extern void InsertAt(uint index, SceneComponent value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(SceneComponent value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] SceneComponent[] items);

    [MethodImpl]
    public extern void ReplaceAll(SceneComponent[] items);

    [MethodImpl]
    public extern IIterator<SceneComponent> First();
  }
}
