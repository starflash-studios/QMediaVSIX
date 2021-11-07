// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderAuthenticationLevel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicates the level of support for magnetic stripe reader authentication protocol: NotSupported, Optional, or Required.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MagneticStripeReaderAuthenticationLevel
  {
    /// <summary>Does not support authentication.</summary>
    NotSupported,
    /// <summary>Supports authentication, but does not require it.</summary>
    Optional,
    /// <summary>Requires authentication.</summary>
    Required,
  }
}
