// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.CellularApnContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>This class contains properties used to specify an Access Point Name (APN) for a 3GPP based cellular Data Connection (PDP context).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CellularApnContext : ICellularApnContext, ICellularApnContext2
  {
    /// <summary>Creates an instance of CellularApnContext.</summary>
    [MethodImpl]
    public extern CellularApnContext();

    /// <summary>Indicates the provider ID associated with the access point.</summary>
    /// <returns>The provider ID.</returns>
    public extern string ProviderId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates the name of the access point to establish a connection with.</summary>
    /// <returns>The access point name.</returns>
    public extern string AccessPointName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates the user name used to authenticate when connecting to the access point.</summary>
    /// <returns>The user name.</returns>
    public extern string UserName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates the password used to authenticate when connecting to the access point.</summary>
    /// <returns>The password associated with the user name.</returns>
    public extern string Password { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates if data compression will be used at the data link for header and data transfer.</summary>
    /// <returns>A Boolean value. TRUE if enabled; otherwise FALSE.</returns>
    public extern bool IsCompressionEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates the authentication method, as defined by CellularApnAuthenticationType, that is used by the access point.</summary>
    /// <returns>The authentication type.</returns>
    public extern CellularApnAuthenticationType AuthenticationType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the name of a cellular profile.</summary>
    /// <returns>The name of a cellular profile.</returns>
    public extern string ProfileName { [MethodImpl] get; [MethodImpl] set; }
  }
}
