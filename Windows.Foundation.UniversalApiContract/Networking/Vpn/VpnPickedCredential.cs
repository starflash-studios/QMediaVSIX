// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnPickedCredential
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Networking.Vpn
{
  /// <summary>**VpnPickedCredential** is not supported and may be altered or unavailable in the future. Instead, use VpnCredential.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnPickedCredential : IVpnPickedCredential
  {
    /// <summary>Not supported. Use VpnCredential instead.</summary>
    /// <returns>Not supported.</returns>
    public extern PasswordCredential PasskeyCredential { [MethodImpl] get; }

    /// <summary>Not supported. Use VpnCredential instead.</summary>
    /// <returns>Not supported.</returns>
    public extern string AdditionalPin { [MethodImpl] get; }

    /// <summary>Not supported. Use VpnCredential instead.</summary>
    /// <returns>Not supported.</returns>
    public extern PasswordCredential OldPasswordCredential { [MethodImpl] get; }
  }
}
