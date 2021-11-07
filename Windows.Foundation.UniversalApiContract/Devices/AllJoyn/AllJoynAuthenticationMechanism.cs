// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynAuthenticationMechanism
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Defines values used to indicate the mechanism used in authentication operations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("AllJoynAuthenticationMechanism has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  public enum AllJoynAuthenticationMechanism
  {
    /// <summary>No mechanism used.</summary>
    None,
    /// <summary>Secure Remote Password (SRP) anonymous has been deprecated and should no longer be used.</summary>
    /// <deprecated type="deprecate">SrpAnonymous is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("SrpAnonymous is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] SrpAnonymous,
    /// <summary>Secure Remote Password (SRP) logon (for example, username and password) has been deprecated and should no longer be used.</summary>
    /// <deprecated type="deprecate">SrpLogon is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("SrpLogon is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] SrpLogon,
    /// <summary>ECDHE_NULL key exchange.</summary>
    EcdheNull,
    /// <summary>ECDHE_PSK has been deprecated and should no longer be used.</summary>
    /// <deprecated type="deprecate">EcdhePsk is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("EcdhePsk is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] EcdhePsk,
    /// <summary>ECDHE_ECDSA key exchange.</summary>
    EcdheEcdsa,
    /// <summary>ECDHE_SPEKE key exchange.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] EcdheSpeke,
  }
}
