// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.DomainConnectivityLevel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Defines the domain authentication status for a network connection.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DomainConnectivityLevel
  {
    /// <summary>No domain controller detected on this network.</summary>
    None,
    /// <summary>A domain controller has been detected, but the current user or local machine have not been authenticated on the domain.</summary>
    Unauthenticated,
    /// <summary>The machine or user is authenticated on the domain connection.</summary>
    Authenticated,
  }
}
