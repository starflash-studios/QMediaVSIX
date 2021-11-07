// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.VisitMonitoringScope
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Contains values that describe the intended scope of location monitoring for use with the Visits feature.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum VisitMonitoringScope
  {
    /// <summary>Monitor all Visit-related events that concern changes in building-sized areas.</summary>
    Venue,
    /// <summary>Monitor only the Visit-related events that concern changes in city-sized areas.</summary>
    City,
  }
}
