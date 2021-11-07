// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneMaterial
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents an asset that describes how a surface is rendered.</summary>
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ISceneMaterialFactory), CompositionType.Public, 524288, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772166)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public class SceneMaterial : SceneObject, ISceneMaterial
  {
  }
}
