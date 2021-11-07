// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ISceneMeshRendererComponentStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [Guid(1230304122, 17497, 17697, 189, 110, 43, 56, 184, 215, 17, 234)]
  [ExclusiveTo(typeof (SceneMeshRendererComponent))]
  internal interface ISceneMeshRendererComponentStatics
  {
    SceneMeshRendererComponent Create(Compositor compositor);
  }
}
