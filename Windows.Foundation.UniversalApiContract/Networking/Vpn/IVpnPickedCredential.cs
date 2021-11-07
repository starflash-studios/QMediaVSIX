// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPickedCredential
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Networking.Vpn
{
  [Guid(2591636167, 34900, 20050, 173, 151, 36, 221, 154, 132, 43, 206)]
  [ExclusiveTo(typeof (VpnPickedCredential))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnPickedCredential
  {
    PasswordCredential PasskeyCredential { get; }

    string AdditionalPin { get; }

    PasswordCredential OldPasswordCredential { get; }
  }
}
