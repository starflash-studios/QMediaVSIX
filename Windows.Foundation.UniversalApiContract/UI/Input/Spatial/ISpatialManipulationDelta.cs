// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialManipulationDelta
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialManipulationDelta))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2817300090, 53539, 14977, 161, 91, 153, 41, 35, 220, 190, 145)]
  internal interface ISpatialManipulationDelta
  {
    Vector3 Translation { get; }
  }
}
