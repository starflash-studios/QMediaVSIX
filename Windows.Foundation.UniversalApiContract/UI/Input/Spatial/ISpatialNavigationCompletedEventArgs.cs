// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialNavigationCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialNavigationCompletedEventArgs))]
  [Guid(19824823, 44859, 17090, 158, 65, 186, 170, 14, 114, 31, 58)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialNavigationCompletedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    Vector3 NormalizedOffset { get; }
  }
}
