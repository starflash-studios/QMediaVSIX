// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosConnectionTypes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Connection types that can be used to access a point of service device.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum PosConnectionTypes : uint
  {
    /// <summary>Locally connected devices, such as USB.</summary>
    Local = 1,
    /// <summary>Devices with an IP address, including both Wired Ethernet and Wi-Fi.</summary>
    IP = 2,
    /// <summary>Devices with a Bluetooth radio.</summary>
    Bluetooth = 4,
    /// <summary>All connection types.</summary>
    All = 4294967295, // 0xFFFFFFFF
  }
}
