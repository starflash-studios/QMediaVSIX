// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.HotspotAuthenticationEventDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides the content of the event that is raised for background task handlers for the hotspot authentication event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HotspotAuthenticationEventDetails : IHotspotAuthenticationEventDetails
  {
    /// <summary>Gets a GUID that uniquely identifies the authentication attempt for which this event was raised.</summary>
    /// <returns>A GUID that uniquely identifies the connection attempt.</returns>
    public extern string EventToken { [MethodImpl] get; }
  }
}
