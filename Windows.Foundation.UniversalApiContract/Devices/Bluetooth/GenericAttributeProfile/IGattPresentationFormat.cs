﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattPresentationFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattPresentationFormat))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(426573857, 64173, 17884, 174, 91, 42, 195, 24, 78, 132, 219)]
  internal interface IGattPresentationFormat
  {
    byte FormatType { get; }

    int Exponent { get; }

    ushort Unit { get; }

    byte Namespace { get; }

    ushort Description { get; }
  }
}