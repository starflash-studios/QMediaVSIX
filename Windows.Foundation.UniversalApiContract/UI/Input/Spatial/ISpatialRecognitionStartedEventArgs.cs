// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialRecognitionStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [Guid(618271375, 8, 19053, 170, 80, 42, 118, 249, 207, 178, 100)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialRecognitionStartedEventArgs))]
  internal interface ISpatialRecognitionStartedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    SpatialPointerPose TryGetPointerPose(SpatialCoordinateSystem coordinateSystem);

    bool IsGesturePossible(SpatialGestureSettings gesture);
  }
}
