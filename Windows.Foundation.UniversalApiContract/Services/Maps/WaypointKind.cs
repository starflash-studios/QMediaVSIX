﻿// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.WaypointKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Specifies the type of waypoint.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum WaypointKind
  {
    /// <summary>A start or stop waypoint of a route or route leg.</summary>
    Stop,
    /// <summary>An intermediate waypoint that a route must pass through.</summary>
    Via,
  }
}