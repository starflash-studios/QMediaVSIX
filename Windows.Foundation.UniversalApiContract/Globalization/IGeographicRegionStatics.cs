// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.IGeographicRegionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(702712180, 31449, 20212, 135, 153, 179, 180, 79, 173, 236, 8)]
  [ExclusiveTo(typeof (GeographicRegion))]
  internal interface IGeographicRegionStatics
  {
    bool IsSupported(string geographicRegionCode);
  }
}
