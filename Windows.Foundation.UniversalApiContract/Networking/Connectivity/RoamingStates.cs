// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.RoamingStates
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Defines the roaming states.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum RoamingStates : uint
  {
    /// <summary>No roaming information.</summary>
    None = 0,
    /// <summary>The connection is not currently roaming.</summary>
    NotRoaming = 1,
    /// <summary>The connection is currently roaming.</summary>
    Roaming = 2,
  }
}
