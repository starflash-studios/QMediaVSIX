// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteFinderStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Returns the status of a MapRouteFinder query. This enumeration provides values for the Status property of a MapRouteFinderResult.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum MapRouteFinderStatus
  {
    /// <summary>The query was successful.</summary>
    Success,
    /// <summary>The query returned an unknown error.</summary>
    UnknownError,
    /// <summary>The query provided credentials that are not valid.</summary>
    InvalidCredentials,
    /// <summary>The query did not find a route.</summary>
    NoRouteFound,
    /// <summary>The query did not find a route with the specified options.</summary>
    NoRouteFoundWithGivenOptions,
    /// <summary>The specified starting point is not valid in a route. For example, the point is in an ocean or a desert.</summary>
    StartPointNotFound,
    /// <summary>The specified ending point is not valid in a route. For example, the point is in an ocean or a desert.</summary>
    EndPointNotFound,
    /// <summary>The query did not find a pedestrian route.</summary>
    NoPedestrianRouteFound,
    /// <summary>The query encountered a network failure.</summary>
    NetworkFailure,
    /// <summary>The query is not supported.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NotSupported,
  }
}
