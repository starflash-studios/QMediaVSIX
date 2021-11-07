// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectInformationElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Represents information elements in a Wi-Fi Direct packet.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWiFiDirectInformationElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WiFiDirectInformationElement : IWiFiDirectInformationElement
  {
    /// <summary>Creates a new WiFiDirectInformationElement object.</summary>
    [MethodImpl]
    public extern WiFiDirectInformationElement();

    /// <summary>A three-byte organization identifier used to indicate the organization which defined a vendor extension information element (IE).</summary>
    /// <returns>A three-byte organization identifier used to indicate the organization which defined a vendor extension IE.</returns>
    public extern IBuffer Oui { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A one byte type value used in a vendor extension information element (IE) to distinguish between different IE formats defined by the same organization.</summary>
    /// <returns>A one byte type value used in a vendor extension information element (IE) to distinguish between different IE formats defined by the same organization.</returns>
    public extern byte OuiType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The value of the information element.</summary>
    /// <returns>The value of the information element.</returns>
    public extern IBuffer Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Create an array of information elements from a data buffer.</summary>
    /// <param name="buffer">The data buffer that contains a information element.</param>
    /// <returns>A array of information elements created from the buffer.</returns>
    [MethodImpl]
    public static extern IVector<WiFiDirectInformationElement> CreateFromBuffer(
      IBuffer buffer);

    /// <summary>Create an array of information elements from a DeviceInformation object.</summary>
    /// <param name="deviceInformation">The device information object that contains the information elements.</param>
    /// <returns>A array of information elements created from the device information object.</returns>
    [MethodImpl]
    public static extern IVector<WiFiDirectInformationElement> CreateFromDeviceInformation(
      DeviceInformation deviceInformation);
  }
}
