// Decompiled with JetBrains decompiler
// Type: Windows.Security.DataProtection.UserDataAvailability
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.DataProtection
{
  /// <summary>Identifies the availability of protected data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum UserDataAvailability
  {
    /// <summary>Data are unprotected when associated with this availability, and are always accessible whether the device is locked or unlocked.</summary>
    Always,
    /// <summary>Data protected to this availability are accessible only after the first device unlock, and will continue to stay available thereafter.</summary>
    AfterFirstUnlock,
    /// <summary>Data protected to this availability are only available when the device is unlocked. </summary>
    WhileUnlocked,
  }
}
