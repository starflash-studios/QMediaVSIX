// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapLocationDesiredAccuracy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Indicates the desired accuracy to use when converting latitude and longitude coordinates to a physical location like a city or address.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public enum MapLocationDesiredAccuracy
  {
    /// <summary>Leverage the underlying REST API call to get richer and more accurate results.</summary>
    High,
    /// <summary>Leverage the maps disk cache to get accurate info up to the city level.</summary>
    Low,
  }
}
