// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialPointerPose3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.People;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(1665332208, 60489, 23371, 184, 209, 209, 108, 187, 22, 190, 132)]
  [ExclusiveTo(typeof (SpatialPointerPose))]
  internal interface ISpatialPointerPose3
  {
    EyesPose Eyes { get; }

    bool IsHeadCapturedBySystem { get; }
  }
}
