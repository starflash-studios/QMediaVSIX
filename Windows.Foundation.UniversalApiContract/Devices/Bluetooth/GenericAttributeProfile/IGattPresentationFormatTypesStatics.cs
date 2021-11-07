// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattPresentationFormatTypesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(4210145802, 12474, 16540, 190, 247, 207, 251, 109, 3, 184, 251)]
  [ExclusiveTo(typeof (GattPresentationFormatTypes))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGattPresentationFormatTypesStatics
  {
    byte Boolean { get; }

    byte Bit2 { get; }

    byte Nibble { get; }

    byte UInt8 { get; }

    byte UInt12 { get; }

    byte UInt16 { get; }

    byte UInt24 { get; }

    byte UInt32 { get; }

    byte UInt48 { get; }

    byte UInt64 { get; }

    byte UInt128 { get; }

    byte SInt8 { get; }

    byte SInt12 { get; }

    byte SInt16 { get; }

    byte SInt24 { get; }

    byte SInt32 { get; }

    byte SInt48 { get; }

    byte SInt64 { get; }

    byte SInt128 { get; }

    byte Float32 { get; }

    byte Float64 { get; }

    byte SFloat { get; }

    byte Float { get; }

    byte DUInt16 { get; }

    byte Utf8 { get; }

    byte Utf16 { get; }

    byte Struct { get; }
  }
}
