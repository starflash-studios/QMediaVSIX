// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectConnectionRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ExclusiveTo(typeof (WiFiDirectConnectionRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4187824318, 54157, 18511, 130, 21, 231, 182, 90, 191, 36, 76)]
  internal interface IWiFiDirectConnectionRequestedEventArgs
  {
    WiFiDirectConnectionRequest GetConnectionRequest();
  }
}
