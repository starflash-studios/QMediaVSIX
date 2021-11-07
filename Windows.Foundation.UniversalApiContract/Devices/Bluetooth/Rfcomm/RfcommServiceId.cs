// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.RfcommServiceId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  /// <summary>Represents an RFCOMM service ID.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Static(typeof (IRfcommServiceIdStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class RfcommServiceId : IRfcommServiceId
  {
    /// <summary>Retrieves the 128-bit service id.</summary>
    /// <returns>The 128-bit service id.</returns>
    public extern Guid Uuid { [MethodImpl] get; }

    /// <summary>Converts the RfcommServiceId to a 32-bit service id if possible.</summary>
    /// <returns>Returns the 32-bit service id if the RfcommServiceId represents a standardized service.</returns>
    [MethodImpl]
    public extern uint AsShortId();

    /// <summary>Converts the RfcommServiceId to a string.</summary>
    /// <returns>Returns the string representation of the 128-bit service id.</returns>
    [MethodImpl]
    public extern string AsString();

    /// <summary>Creates a RfcommServiceId object from a 128-bit service id.</summary>
    /// <param name="uuid">The 128-bit service id.</param>
    /// <returns>The RfcommServiceId object.</returns>
    [MethodImpl]
    public static extern RfcommServiceId FromUuid(Guid uuid);

    /// <summary>Creates a RfcommServiceId object from a 32-bit service id.</summary>
    /// <param name="shortId">The 32-bit service id.</param>
    /// <returns>The RfcommServiceId object.</returns>
    [MethodImpl]
    public static extern RfcommServiceId FromShortId(uint shortId);

    /// <summary>Creates a RfcommServiceId object corresponding to the service id for the standardized Serial Port service (with short id 0x1101).</summary>
    /// <returns>The RfcommServiceId object that represents the service id for the Serial Port service.</returns>
    public static extern RfcommServiceId SerialPort { [MethodImpl] get; }

    /// <summary>Creates a RfcommServiceId object corresponding to the service id for the standardized OBEX Object Push service (with short id 0x1105).</summary>
    /// <returns>The RfcommServiceId object that represents the service id for the OBEX Object Push service.</returns>
    public static extern RfcommServiceId ObexObjectPush { [MethodImpl] get; }

    /// <summary>Creates a RfcommServiceId object corresponding to the service id for the standardized OBEX File Transfer service (with short id 0x1106).</summary>
    /// <returns>The RfcommServiceId object that represents the service id for the Obex File Transfer service.</returns>
    public static extern RfcommServiceId ObexFileTransfer { [MethodImpl] get; }

    /// <summary>Creates a RfcommServiceId object corresponding to the service id for the standardized Phone Book Access (PCE) service (with short id 0x112E).</summary>
    /// <returns>The RfcommServiceId object that represents the service id for the Phone Book Access (PCE) service.</returns>
    public static extern RfcommServiceId PhoneBookAccessPce { [MethodImpl] get; }

    /// <summary>Creates a RfcommServiceId object corresponding to the service id for the standardized Phone Book Access (PSE) service (with short id 0x112F).</summary>
    /// <returns>The RfcommServiceId object that represents the service id for the Phone Book Access (PSE) service.</returns>
    public static extern RfcommServiceId PhoneBookAccessPse { [MethodImpl] get; }

    /// <summary>Creates a RfcommServiceId object corresponding to the service id for the standardized Generic File Transfer service (with short id 0x1202).</summary>
    /// <returns>The RfcommServiceId object that represents the service id for the Generic File Transfer service.</returns>
    public static extern RfcommServiceId GenericFileTransfer { [MethodImpl] get; }
  }
}
