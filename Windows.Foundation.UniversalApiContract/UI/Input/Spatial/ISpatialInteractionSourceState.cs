// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSourceState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [Guid(3586422255, 19299, 14316, 152, 185, 159, 198, 82, 185, 210, 242)]
  [ExclusiveTo(typeof (SpatialInteractionSourceState))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialInteractionSourceState
  {
    SpatialInteractionSource Source { get; }

    SpatialInteractionSourceProperties Properties { get; }

    bool IsPressed { get; }

    PerceptionTimestamp Timestamp { get; }

    SpatialPointerPose TryGetPointerPose(SpatialCoordinateSystem coordinateSystem);
  }
}
