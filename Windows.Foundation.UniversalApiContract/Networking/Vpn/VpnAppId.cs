// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnAppId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Represents an application identifier, which can be a file path, a package family name, or a fully qualified binary name (FQBN) string.</summary>
  [Activatable(typeof (IVpnAppIdFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnAppId : IVpnAppId
  {
    /// <summary>Creates a **VpnAppId** object with specified app ID and type.</summary>
    /// <param name="type">The type of app ID to be created.</param>
    /// <param name="value">The value of the app ID to be created. Value must be correct for the given *type* value.</param>
    [MethodImpl]
    public extern VpnAppId(VpnAppIdType type, string value);

    /// <summary>Gets or sets the type of the app ID.</summary>
    /// <returns>An enum value that corresponds to the type of the app ID.</returns>
    public extern VpnAppIdType Type { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value of the app ID.</summary>
    /// <returns>The app ID. The format of the ID must be correct for the VpnAppId.Type value.</returns>
    public extern string Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
