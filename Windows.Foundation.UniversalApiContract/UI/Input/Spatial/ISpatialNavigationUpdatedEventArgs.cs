// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialNavigationUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2607890391, 33693, 19060, 135, 50, 69, 70, 111, 192, 68, 181)]
  [ExclusiveTo(typeof (SpatialNavigationUpdatedEventArgs))]
  internal interface ISpatialNavigationUpdatedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    Vector3 NormalizedOffset { get; }
  }
}
