// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneMeshMaterialAttributeMap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents a collection of material attributes for a scene mesh as key/value pairs.</summary>
  [DualApiPartition(version = 167772166)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  public sealed class SceneMeshMaterialAttributeMap : 
    SceneObject,
    ISceneMeshMaterialAttributeMap,
    IMap<string, SceneAttributeSemantic>,
    IIterable<IKeyValuePair<string, SceneAttributeSemantic>>
  {
    [MethodImpl]
    public extern SceneAttributeSemantic Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, SceneAttributeSemantic> GetView();

    [MethodImpl]
    public extern bool Insert(string key, SceneAttributeSemantic value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, SceneAttributeSemantic>> First();
  }
}
