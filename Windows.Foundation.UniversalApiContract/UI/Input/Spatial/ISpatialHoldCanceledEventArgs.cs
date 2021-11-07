// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialHoldCanceledEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [Guid(1576842855, 19626, 16531, 140, 53, 182, 1, 168, 57, 243, 27)]
  [ExclusiveTo(typeof (SpatialHoldCanceledEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialHoldCanceledEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }
  }
}
