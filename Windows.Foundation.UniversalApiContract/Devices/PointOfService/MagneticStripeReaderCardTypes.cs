// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderCardTypes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Contains the card type of the recently swiped card.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMagneticStripeReaderCardTypesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class MagneticStripeReaderCardTypes
  {
    /// <summary>Indicates an unknown card type.</summary>
    /// <returns>Unknown card type.</returns>
    public static extern uint Unknown { [MethodImpl] get; }

    /// <summary>Indicates a bank card type.</summary>
    /// <returns>Bank card type.</returns>
    public static extern uint Bank { [MethodImpl] get; }

    /// <summary>Indicates the American Association of Motor Vehicle Administrators (AAMVA) card type.</summary>
    /// <returns>The AAMVA card type.</returns>
    public static extern uint Aamva { [MethodImpl] get; }

    /// <summary>Indicates vendor-specific card type.</summary>
    /// <returns>Vendor-specific card type.</returns>
    public static extern uint ExtendedBase { [MethodImpl] get; }
  }
}
