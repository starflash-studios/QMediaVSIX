// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionDetectedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialInteractionDetectedEventArgs))]
  [Guid(2066103955, 24339, 16796, 151, 213, 131, 70, 120, 38, 106, 166)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialInteractionDetectedEventArgs2 : ISpatialInteractionDetectedEventArgs
  {
    SpatialInteractionSource InteractionSource { get; }
  }
}
