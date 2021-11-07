// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ISceneMesh
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.UI.Composition.Scenes
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [Guid(4003075376, 4437, 19468, 146, 189, 64, 2, 12, 247, 131, 71)]
  [ExclusiveTo(typeof (SceneMesh))]
  internal interface ISceneMesh
  {
    SceneBoundingBox Bounds { get; }

    DirectXPrimitiveTopology PrimitiveTopology { get; set; }

    void FillMeshAttribute(
      SceneAttributeSemantic semantic,
      DirectXPixelFormat format,
      MemoryBuffer memory);
  }
}
