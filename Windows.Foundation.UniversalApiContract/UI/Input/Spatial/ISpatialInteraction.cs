// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteraction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [Guid(4237719097, 35046, 17990, 145, 18, 67, 68, 170, 236, 157, 250)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialInteraction))]
  internal interface ISpatialInteraction
  {
    SpatialInteractionSourceState SourceState { get; }
  }
}
