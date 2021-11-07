// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDRegistrationCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Provides arguments for the PlayReady-ND RegistrationCompleted event.</summary>
  /// <deprecated type="deprecate">INDRegistrationCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Guid(2654582349, 43867, 18693, 172, 220, 120, 122, 119, 198, 55, 77)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("INDRegistrationCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public interface INDRegistrationCompletedEventArgs
  {
    /// <summary>Gets custom data from a registration response.</summary>
    /// <returns>The custom data from the registration response.</returns>
    INDCustomData ResponseCustomData { [Deprecated("INDRegistrationCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets transmitter properties from the transmitter's certificate to verify the transmitter.</summary>
    /// <returns>The properties of the transmitter's certificate.</returns>
    INDTransmitterProperties TransmitterProperties { [Deprecated("INDRegistrationCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets or sets whether to accept or reject a transmitter's certificate.</summary>
    /// <returns>The result from verifying the transmitter's certificate. This value is **true** if the receiver accepts the transmitter certificate or **false** if it rejects the certificate.</returns>
    bool TransmitterCertificateAccepted { [Deprecated("INDRegistrationCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("INDRegistrationCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] set; }
  }
}
