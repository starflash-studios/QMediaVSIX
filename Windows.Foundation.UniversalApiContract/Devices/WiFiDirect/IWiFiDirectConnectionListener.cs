// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectConnectionListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ExclusiveTo(typeof (WiFiDirectConnectionListener))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1771838221, 36115, 20201, 185, 236, 156, 114, 248, 37, 31, 125)]
  internal interface IWiFiDirectConnectionListener
  {
    event TypedEventHandler<WiFiDirectConnectionListener, WiFiDirectConnectionRequestedEventArgs> ConnectionRequested;
  }
}
