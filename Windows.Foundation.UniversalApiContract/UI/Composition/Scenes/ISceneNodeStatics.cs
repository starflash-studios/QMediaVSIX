// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ISceneNodeStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (SceneNode))]
  [Guid(1469714346, 48797, 16912, 144, 140, 147, 209, 95, 238, 208, 183)]
  internal interface ISceneNodeStatics
  {
    SceneNode Create(Compositor compositor);
  }
}
