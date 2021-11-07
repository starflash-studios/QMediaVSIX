// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ISceneMeshStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  [ExclusiveTo(typeof (SceneMesh))]
  [WebHostHidden]
  [Guid(2215784812, 31575, 18239, 150, 107, 129, 220, 39, 123, 23, 81)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ISceneMeshStatics
  {
    SceneMesh Create(Compositor compositor);
  }
}
