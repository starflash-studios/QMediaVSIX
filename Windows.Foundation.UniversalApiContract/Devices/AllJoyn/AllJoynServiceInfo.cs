// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynServiceInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Exposes unique name and transport information for an advertising app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("AllJoynServiceInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAllJoynServiceInfoStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IAllJoynServiceInfoFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AllJoynServiceInfo : IAllJoynServiceInfo
  {
    /// <summary>Generates an AllJoynServiceInfo object that represents an advertising app. This object provides the unique bus name, object path and transport information.</summary>
    /// <param name="uniqueName">The unique bus name.</param>
    /// <param name="objectPath">The object path.</param>
    /// <param name="sessionPort">The port for this session.</param>
    [Deprecated("AllJoynServiceInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynServiceInfo(string uniqueName, string objectPath, ushort sessionPort);

    /// <summary>The unique bus name associated with the advertising app.</summary>
    /// <returns>The unique name.</returns>
    public extern string UniqueName { [Deprecated("AllJoynServiceInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The path to the service object. This path is used to match communications with service objects connected to the session.</summary>
    /// <returns>The service object path.</returns>
    public extern string ObjectPath { [Deprecated("AllJoynServiceInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The port used to connect to the session.</summary>
    /// <returns>The connection port number.</returns>
    public extern ushort SessionPort { [Deprecated("AllJoynServiceInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Converts a DeviceInformation ID acquired by a device enumeration into an AllJoynServiceInfo object.</summary>
    /// <param name="deviceId">The acquired DeviceInformation ID.</param>
    /// <returns>The AllJoynServiceInfo object corresponding to the ID. This object can be used to establish sessions with remote endpoints and to retrieve About data from them.</returns>
    [Deprecated("AllJoynServiceInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AllJoynServiceInfo> FromIdAsync(
      string deviceId);
  }
}
