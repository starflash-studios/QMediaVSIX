// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.IGeographicRegionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Guid(1396855408, 30644, 17003, 133, 159, 129, 225, 157, 81, 37, 70)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GeographicRegion))]
  internal interface IGeographicRegionFactory
  {
    GeographicRegion CreateGeographicRegion(string geographicRegionCode);
  }
}
