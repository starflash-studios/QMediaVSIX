// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.IEyesPose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Perception.People
{
  [Guid(1747622691, 35358, 23430, 160, 96, 144, 111, 250, 203, 98, 164)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (EyesPose))]
  internal interface IEyesPose
  {
    bool IsCalibrationValid { get; }

    IReference<SpatialRay> Gaze { get; }

    PerceptionTimestamp UpdateTimestamp { get; }
  }
}
