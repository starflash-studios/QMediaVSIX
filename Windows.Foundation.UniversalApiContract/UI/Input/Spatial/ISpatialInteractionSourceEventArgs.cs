// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSourceEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(599230159, 60451, 14713, 178, 124, 235, 14, 18, 254, 183, 199)]
  [ExclusiveTo(typeof (SpatialInteractionSourceEventArgs))]
  internal interface ISpatialInteractionSourceEventArgs
  {
    SpatialInteractionSourceState State { get; }
  }
}
