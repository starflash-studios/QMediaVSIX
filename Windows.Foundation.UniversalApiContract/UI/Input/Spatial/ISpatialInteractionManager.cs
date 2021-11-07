// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialInteractionManager))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(849759912, 41306, 14741, 184, 189, 128, 81, 60, 181, 173, 239)]
  internal interface ISpatialInteractionManager
  {
    event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceDetected;

    event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceLost;

    event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceUpdated;

    event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourcePressed;

    event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceReleased;

    event TypedEventHandler<SpatialInteractionManager, SpatialInteractionDetectedEventArgs> InteractionDetected;

    IVectorView<SpatialInteractionSourceState> GetDetectedSourcesAtTimestamp(
      PerceptionTimestamp timeStamp);
  }
}
