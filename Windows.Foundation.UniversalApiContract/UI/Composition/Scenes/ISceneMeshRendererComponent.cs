// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ISceneMeshRendererComponent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SceneMeshRendererComponent))]
  [Guid(2569664483, 25444, 18302, 152, 254, 116, 237, 159, 212, 194, 222)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ISceneMeshRendererComponent
  {
    SceneMaterial Material { get; set; }

    SceneMesh Mesh { get; set; }

    SceneMeshMaterialAttributeMap UVMappings { get; }
  }
}
