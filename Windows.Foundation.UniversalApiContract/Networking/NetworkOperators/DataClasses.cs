// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.DataClasses
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes the cellular data services supported by a mobile broadband network device.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DataClasses : uint
  {
    /// <summary>No data services supported.</summary>
    None = 0,
    /// <summary>The device supports the GPRS data service implemented by GSM providers.</summary>
    Gprs = 1,
    /// <summary>The device supports the EDGE data service implemented by GSM providers.</summary>
    Edge = 2,
    /// <summary>The device supports the UMTS data service implemented by GSM providers.</summary>
    Umts = 4,
    /// <summary>The device supports the HSDPA data service implemented by GSM providers.</summary>
    Hsdpa = 8,
    /// <summary>The device supports the HSUPA (High Speed Uplink Packet Access) data service.</summary>
    Hsupa = 16, // 0x00000010
    /// <summary>The device supports the HSDPA Lite data service implemented by GSM providers.</summary>
    LteAdvanced = 32, // 0x00000020
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] NewRadioNonStandalone = 64, // 0x00000040
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] NewRadioStandalone = 128, // 0x00000080
    /// <summary>The device supports the 1xRTT data service implemented by CDMA providers.</summary>
    Cdma1xRtt = 65536, // 0x00010000
    /// <summary>The device supports the 1xEV-DO data service implemented by CDMA providers.</summary>
    Cdma1xEvdo = 131072, // 0x00020000
    /// <summary>The device supports the 1xEV-DO RevA data service implemented by CDMA providers.</summary>
    Cdma1xEvdoRevA = 262144, // 0x00040000
    /// <summary>The device supports the 1xEV-DV data service implemented by CDMA providers.</summary>
    Cdma1xEvdv = 524288, // 0x00080000
    /// <summary>The device supports the 3xRTT data service implemented by CDMA providers.</summary>
    Cdma3xRtt = 1048576, // 0x00100000
    /// <summary>The device supports the 1xEV-DO RevB data service, which is identified for future use.</summary>
    Cdma1xEvdoRevB = 2097152, // 0x00200000
    /// <summary>The device supports the UMB data service implemented by CDMA providers.</summary>
    CdmaUmb = 4194304, // 0x00400000
    /// <summary>The device supports a custom data service.</summary>
    Custom = 2147483648, // 0x80000000
  }
}
