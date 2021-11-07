// Decompiled with JetBrains decompiler
// Type: Windows.Management.MdmAlert
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  /// <summary>Provides functionality to configure the data sent to the mobile device management server.</summary>
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class MdmAlert : IMdmAlert
  {
    /// <summary>An MDM alert with custom data fields.</summary>
    [MethodImpl]
    public extern MdmAlert();

    /// <summary>Custom MDM data sent to the server.</summary>
    /// <returns>String form of the data sent to the server.</returns>
    public extern string Data { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The data format of the MDM alert.</summary>
    /// <returns>An MdmAlertDataType enumeration value.</returns>
    public extern MdmAlertDataType Format { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The priority or criticality of the alert.</summary>
    /// <returns>An MdmAlertMark enumeration value.</returns>
    public extern MdmAlertMark Mark { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The local URI path to the source of the alert.</summary>
    /// <returns>The string value of the URI path.</returns>
    public extern string Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A read-only status code sent by the server in response to the alert.</summary>
    /// <returns>Integer form of the status code (200, 404, etc.).</returns>
    public extern uint Status { [MethodImpl] get; }

    /// <summary>The local URI path to the inventory location of the application.</summary>
    /// <returns>The string value of the URI path.</returns>
    public extern string Target { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The type of the alert. This is also the alert ID.</summary>
    /// <returns>A reversed domain name formatted string.</returns>
    public extern string Type { [MethodImpl] get; [MethodImpl] set; }
  }
}
