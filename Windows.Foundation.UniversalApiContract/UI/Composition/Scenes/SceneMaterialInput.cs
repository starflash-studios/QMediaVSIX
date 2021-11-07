// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneMaterialInput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents an input that influences a material.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Composable(typeof (ISceneMaterialInputFactory), CompositionType.Public, 524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772166)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class SceneMaterialInput : SceneObject, ISceneMaterialInput
  {
  }
}
