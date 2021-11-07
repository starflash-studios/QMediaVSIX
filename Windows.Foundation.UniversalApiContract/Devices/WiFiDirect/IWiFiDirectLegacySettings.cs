// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectLegacySettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Devices.WiFiDirect
{
  [ExclusiveTo(typeof (WiFiDirectLegacySettings))]
  [Guid(2790251450, 62205, 17767, 169, 27, 245, 194, 245, 50, 16, 87)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectLegacySettings
  {
    bool IsEnabled { get; set; }

    string Ssid { get; set; }

    PasswordCredential Passphrase { get; set; }
  }
}
