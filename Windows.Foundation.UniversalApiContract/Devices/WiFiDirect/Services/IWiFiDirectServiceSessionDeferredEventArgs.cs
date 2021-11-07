// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceSessionDeferredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2382109055, 4609, 20255, 182, 244, 93, 241, 183, 185, 251, 46)]
  [ExclusiveTo(typeof (WiFiDirectServiceSessionDeferredEventArgs))]
  internal interface IWiFiDirectServiceSessionDeferredEventArgs
  {
    IBuffer DeferredSessionInfo { get; }
  }
}
