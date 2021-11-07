// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeocoordinateWithPositionSourceTimestamp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2235825154, 51697, 17936, 175, 224, 139, 195, 166, 168, 112, 54)]
  [ExclusiveTo(typeof (Geocoordinate))]
  internal interface IGeocoordinateWithPositionSourceTimestamp
  {
    IReference<DateTime> PositionSourceTimestamp { get; }
  }
}
