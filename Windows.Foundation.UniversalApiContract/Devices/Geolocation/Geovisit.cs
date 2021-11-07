// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geovisit
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Represents a Visit-related state change. See Guidelines for using Visits tracking for information on how to use this feature.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Geovisit : IGeovisit
  {
    /// <summary>Gets the location where this Visit-related state change took place.</summary>
    /// <returns>The location of the Visit-related state change.</returns>
    public extern Geoposition Position { [MethodImpl] get; }

    /// <summary>Gets the type of state change that this Geovisit instance represents.</summary>
    /// <returns>A VisitStateChange value representing the type of change.</returns>
    public extern VisitStateChange StateChange { [MethodImpl] get; }

    /// <summary>Gets the time that this Visit-related state change happened.</summary>
    /// <returns>A DateTime instance representing the time the state change happened.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }
  }
}
