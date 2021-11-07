// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ITileMixedRealityModel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.StartScreen
{
  [ExclusiveTo(typeof (TileMixedRealityModel))]
  [Guid(2960543323, 34941, 16962, 154, 25, 61, 10, 78, 167, 128, 49)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ITileMixedRealityModel
  {
    Uri Uri { set; get; }

    IReference<SpatialBoundingBox> BoundingBox { set; get; }
  }
}
