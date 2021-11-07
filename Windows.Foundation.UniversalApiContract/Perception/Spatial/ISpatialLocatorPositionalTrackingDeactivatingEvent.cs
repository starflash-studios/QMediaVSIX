// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialLocatorPositionalTrackingDeactivatingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3098034275, 58356, 13963, 144, 97, 158, 169, 209, 214, 204, 22)]
  [ExclusiveTo(typeof (SpatialLocatorPositionalTrackingDeactivatingEventArgs))]
  internal interface ISpatialLocatorPositionalTrackingDeactivatingEventArgs
  {
    bool Canceled { get; set; }
  }
}
