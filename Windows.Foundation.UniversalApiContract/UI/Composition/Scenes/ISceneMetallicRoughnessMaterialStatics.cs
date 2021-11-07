// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ISceneMetallicRoughnessMaterialStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  [Guid(1004390992, 28061, 17713, 141, 196, 178, 126, 62, 73, 183, 171)]
  [ExclusiveTo(typeof (SceneMetallicRoughnessMaterial))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ISceneMetallicRoughnessMaterialStatics
  {
    SceneMetallicRoughnessMaterial Create(Compositor compositor);
  }
}
