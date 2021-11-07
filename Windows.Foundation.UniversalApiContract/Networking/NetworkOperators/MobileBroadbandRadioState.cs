// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandRadioState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes radio states for a Mobile Broadband device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MobileBroadbandRadioState
  {
    /// <summary>The radio is off. This can be because it has been turned off using a physical switch on the device, or using a software mechanism such as **Airplane Mode** on the control panel.</summary>
    Off,
    /// <summary>The radio is on.</summary>
    On,
  }
}
