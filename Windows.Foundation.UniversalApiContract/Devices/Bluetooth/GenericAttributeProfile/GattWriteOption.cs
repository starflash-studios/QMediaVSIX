// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattWriteOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Indicates what type of write operation is to be performed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum GattWriteOption
  {
    /// <summary>The default GATT write procedure shall be used.</summary>
    WriteWithResponse,
    /// <summary>The Write Without Response procedure shall be used.</summary>
    WriteWithoutResponse,
  }
}
