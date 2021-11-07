// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ISceneNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  [WebHostHidden]
  [Guid(2901590599, 62215, 17793, 156, 65, 175, 46, 41, 195, 176, 22)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (SceneNode))]
  internal interface ISceneNode
  {
    SceneNodeCollection Children { get; }

    SceneComponentCollection Components { get; }

    SceneNode Parent { get; }

    SceneModelTransform Transform { get; }

    SceneComponent FindFirstComponentOfType(SceneComponentType value);
  }
}
