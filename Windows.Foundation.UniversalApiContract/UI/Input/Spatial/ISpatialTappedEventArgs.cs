// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialTappedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(695043038, 62532, 19105, 178, 191, 157, 200, 141, 86, 125, 166)]
  [ExclusiveTo(typeof (SpatialTappedEventArgs))]
  internal interface ISpatialTappedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    SpatialPointerPose TryGetPointerPose(SpatialCoordinateSystem coordinateSystem);

    uint TapCount { get; }
  }
}
