// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialEntityRemovedEventArgs))]
  [Guid(2440304640, 21357, 20127, 171, 246, 65, 91, 84, 68, 214, 81)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialEntityRemovedEventArgs
  {
    SpatialEntity Entity { get; }
  }
}
