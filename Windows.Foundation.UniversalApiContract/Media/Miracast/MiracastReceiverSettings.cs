// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>An object with configuration settings for the MiracastReceiver.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MiracastReceiverSettings : IMiracastReceiverSettings
  {
    /// <summary>Specifies the friendly name of the MiracastReceiver.</summary>
    /// <returns>The friendly name of the Miracast Receiver.</returns>
    public extern string FriendlyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A human-readable string that specifies the model name of the Miracast Receiver app.</summary>
    /// <returns>The model name of the Miracast Receiver app.</returns>
    public extern string ModelName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A human-readable string that specifies the model number or other version information of the Miracast Receiver app.</summary>
    /// <returns>The model number or other version information of the Miracast Receiver app.</returns>
    public extern string ModelNumber { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the desired authorization method for incoming Miracast connections.</summary>
    /// <returns>The desired authorization method for incoming Miracast connections.</returns>
    public extern MiracastReceiverAuthorizationMethod AuthorizationMethod { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies if authorization should be required by Miracast Transmitters that are already known to the Miracast Receiver.</summary>
    /// <returns>True if authorization should be required by Miracast Transmitters that are already known to the Miracast Receiver.</returns>
    public extern bool RequireAuthorizationFromKnownTransmitters { [MethodImpl] get; [MethodImpl] set; }
  }
}
