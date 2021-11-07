// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.GraphicsTrustStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Describes the status of graphics trusted output.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum GraphicsTrustStatus
  {
    /// <summary>Trusted output is not required.</summary>
    TrustNotRequired,
    /// <summary>Trust output has been established.</summary>
    TrustEstablished,
    /// <summary>The environment is not supported for trusted output.</summary>
    EnvironmentNotSupported,
    /// <summary>Driver not supported for trusted output.</summary>
    DriverNotSupported,
    /// <summary>Driver signing failed for trusted output.</summary>
    DriverSigningFailure,
    /// <summary>Unspecified error occurred.</summary>
    UnknownFailure,
  }
}
