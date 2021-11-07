// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.UnsupportedAppRequirementReasons
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  /// <summary>Indicate why an App Capability is unsupported on the current device</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Flags]
  public enum UnsupportedAppRequirementReasons : uint
  {
    /// <summary>The reason is unknown</summary>
    Unknown = 0,
    /// <summary>The system has indicated that the capability is not available</summary>
    DeniedBySystem = 1,
  }
}
