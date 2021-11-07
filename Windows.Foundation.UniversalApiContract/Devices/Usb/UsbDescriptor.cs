// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  /// <summary>Provides information about the type of descriptor, its size (in bytes), and gets the descriptor data.</summary>
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UsbDescriptor : IUsbDescriptor
  {
    /// <summary>Gets the length of the descriptor.</summary>
    /// <returns>The length of the descriptor.</returns>
    public extern byte Length { [MethodImpl] get; }

    /// <summary>Gets the type of descriptor.</summary>
    /// <returns>The type of descriptor.</returns>
    public extern byte DescriptorType { [MethodImpl] get; }

    /// <summary>Reads descriptor data in the caller-supplied buffer.</summary>
    /// <param name="buffer">A caller-supplied buffer that receives descriptor data.</param>
    [MethodImpl]
    public extern void ReadDescriptorBuffer(IBuffer buffer);
  }
}
