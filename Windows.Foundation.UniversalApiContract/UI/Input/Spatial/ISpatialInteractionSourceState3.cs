// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSourceState3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.People;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(4075817922, 48427, 18945, 168, 251, 50, 62, 1, 88, 82, 124)]
  [ExclusiveTo(typeof (SpatialInteractionSourceState))]
  internal interface ISpatialInteractionSourceState3 : 
    ISpatialInteractionSourceState2,
    ISpatialInteractionSourceState
  {
    HandPose TryGetHandPose();
  }
}
