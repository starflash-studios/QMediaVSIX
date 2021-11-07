// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialNavigationStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialNavigationStartedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1967797386, 64356, 18006, 142, 189, 157, 238, 202, 175, 228, 117)]
  internal interface ISpatialNavigationStartedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    SpatialPointerPose TryGetPointerPose(SpatialCoordinateSystem coordinateSystem);

    bool IsNavigatingX { get; }

    bool IsNavigatingY { get; }

    bool IsNavigatingZ { get; }
  }
}
