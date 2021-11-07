// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDevicePairingRequestedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(3359068889, 58579, 19888, 163, 96, 161, 5, 228, 55, 219, 220)]
  [ExclusiveTo(typeof (DevicePairingRequestedEventArgs))]
  internal interface IDevicePairingRequestedEventArgs2
  {
    void AcceptWithPasswordCredential(PasswordCredential passwordCredential);
  }
}
