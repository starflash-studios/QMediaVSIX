// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.IWiFiWpsConfigurationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFi
{
  [ExclusiveTo(typeof (WiFiWpsConfigurationResult))]
  [Guid(1739888753, 6126, 17105, 177, 79, 90, 17, 241, 34, 111, 181)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IWiFiWpsConfigurationResult
  {
    WiFiWpsConfigurationStatus Status { get; }

    IVectorView<WiFiWpsKind> SupportedWpsKinds { get; }
  }
}
