// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ISceneModelTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Scenes
{
  [WebHostHidden]
  [Guid(3226826434, 12977, 17001, 152, 13, 185, 133, 55, 16, 10, 228)]
  [ExclusiveTo(typeof (SceneModelTransform))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ISceneModelTransform
  {
    Quaternion Orientation { get; set; }

    float RotationAngle { get; set; }

    float RotationAngleInDegrees { get; set; }

    Vector3 RotationAxis { get; set; }

    Vector3 Scale { get; set; }

    Vector3 Translation { get; set; }
  }
}
