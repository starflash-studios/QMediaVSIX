// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.FlightStickButtons
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>Specifies the type of flight stick button.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Flags]
  public enum FlightStickButtons : uint
  {
    /// <summary>No button.</summary>
    None = 0,
    /// <summary>The primary fire button.</summary>
    FirePrimary = 1,
    /// <summary>The secondary fire button.</summary>
    FireSecondary = 2,
  }
}
