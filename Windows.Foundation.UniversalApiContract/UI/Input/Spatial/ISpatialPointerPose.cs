// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialPointerPose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;
using Windows.Perception.People;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialPointerPose))]
  [Guid(1767089198, 49534, 13693, 151, 161, 114, 105, 208, 237, 45, 16)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialPointerPose
  {
    PerceptionTimestamp Timestamp { get; }

    HeadPose Head { get; }
  }
}
