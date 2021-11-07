// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapManeuverNotices
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Provides additional information about a maneuver. This enumeration provides values for the ManeuverNotices property of a MapRouteManeuver.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Flags]
  public enum MapManeuverNotices : uint
  {
    /// <summary>There is no additional information.</summary>
    None = 0,
    /// <summary>The maneuver includes a toll road.</summary>
    Toll = 1,
    /// <summary>The maneuver includes an unpaved road.</summary>
    Unpaved = 2,
  }
}
