// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbDeviceClass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Provides a way for the app to get an Advanced Query Syntax (AQS) string by specifying the class code, subclass code, and the protocol code defined by the device. The properties in this class are passed in the call to GetDeviceClassSelector.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UsbDeviceClass : IUsbDeviceClass
  {
    /// <summary>Creates a UsbDeviceClass object.</summary>
    [MethodImpl]
    public extern UsbDeviceClass();

    /// <summary>Gets or sets the class code of the device.</summary>
    /// <returns>The device class code.</returns>
    public extern byte ClassCode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the subclass code of the device.</summary>
    /// <returns>The subclass code of the device.</returns>
    public extern IReference<byte> SubclassCode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the protocol code of the device.</summary>
    /// <returns>The protocol code of the device.</returns>
    public extern IReference<byte> ProtocolCode { [MethodImpl] get; [MethodImpl] set; }
  }
}
