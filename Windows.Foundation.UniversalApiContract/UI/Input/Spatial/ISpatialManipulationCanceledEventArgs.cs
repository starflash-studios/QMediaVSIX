// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialManipulationCanceledEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialManipulationCanceledEventArgs))]
  [Guid(759222731, 59354, 16928, 176, 191, 129, 147, 1, 103, 71, 128)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialManipulationCanceledEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }
  }
}
