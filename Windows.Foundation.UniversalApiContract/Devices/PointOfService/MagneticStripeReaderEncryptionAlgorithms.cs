// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderEncryptionAlgorithms
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Contains the encryption algorithm supported by the device.</summary>
  [Static(typeof (IMagneticStripeReaderEncryptionAlgorithmsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class MagneticStripeReaderEncryptionAlgorithms
  {
    /// <summary>Indicates no encryption algorithm.</summary>
    /// <returns>No encryption algorithm.</returns>
    public static extern uint None { [MethodImpl] get; }

    /// <summary>Indicates Triple DES DUKPT (Derived Unique Key Per Transaction) encryption algorithm supported by the device.</summary>
    /// <returns>The Triple DES DUKPT encryption algorithm.</returns>
    public static extern uint TripleDesDukpt { [MethodImpl] get; }

    /// <summary>Indicates vendor specific encryption algorithm.</summary>
    /// <returns>Vendor-specific algorithm.</returns>
    public static extern uint ExtendedBase { [MethodImpl] get; }
  }
}
