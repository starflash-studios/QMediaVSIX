// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeoboundingBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(144099339, 10063, 17370, 154, 6, 203, 252, 218, 235, 78, 194)]
  [ExclusiveTo(typeof (GeoboundingBox))]
  internal interface IGeoboundingBox : IGeoshape
  {
    BasicGeoposition NorthwestCorner { get; }

    BasicGeoposition SoutheastCorner { get; }

    BasicGeoposition Center { get; }

    double MinAltitude { get; }

    double MaxAltitude { get; }
  }
}
