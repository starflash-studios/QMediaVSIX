// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapLocationFinderStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Returns the status of a MapLocationFinder query. This enumeration provides values for the Status property of a MapLocationFinderResult.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum MapLocationFinderStatus
  {
    /// <summary>Query search operation was successful. Check result size before accessing results.</summary>
    Success,
    /// <summary>The query returned an unknown error.</summary>
    UnknownError,
    /// <summary>The query provided credentials that are not valid.</summary>
    InvalidCredentials,
    /// <summary>The specified point cannot be converted to a location. For example, the point is in an ocean or a desert.</summary>
    BadLocation,
    /// <summary>The query encountered an internal error.</summary>
    IndexFailure,
    /// <summary>The query encountered a network failure.</summary>
    NetworkFailure,
    /// <summary>The query is not supported.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NotSupported,
  }
}
