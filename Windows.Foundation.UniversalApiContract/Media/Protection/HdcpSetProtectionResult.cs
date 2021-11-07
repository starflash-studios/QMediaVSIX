// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.HdcpSetProtectionResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Describes whether setting HDCP was successful.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum HdcpSetProtectionResult
  {
    /// <summary>HDCP was successfully set.</summary>
    Success,
    /// <summary>The HDCP operation timed out and protection was not set.</summary>
    TimedOut,
    /// <summary>The device doesn't support the HDCP level that was attempted.</summary>
    NotSupported,
    /// <summary>The HDCP operation failed for an unknown reason.</summary>
    UnknownFailure,
  }
}
