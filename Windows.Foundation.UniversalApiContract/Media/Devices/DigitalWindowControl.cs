﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.DigitalWindowControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  public sealed class DigitalWindowControl : IDigitalWindowControl
  {
    public extern bool IsSupported { [MethodImpl] get; }

    public extern DigitalWindowMode[] SupportedModes { [MethodImpl] get; }

    public extern DigitalWindowMode CurrentMode { [MethodImpl] get; }

    [MethodImpl]
    public extern DigitalWindowBounds GetBounds();

    [Overload("Configure")]
    [MethodImpl]
    public extern void Configure(DigitalWindowMode digitalWindowMode);

    [Overload("ConfigureWithBounds")]
    [MethodImpl]
    public extern void Configure(
      DigitalWindowMode digitalWindowMode,
      DigitalWindowBounds digitalWindowBounds);

    public extern IVectorView<DigitalWindowCapability> SupportedCapabilities { [MethodImpl] get; }

    [MethodImpl]
    public extern DigitalWindowCapability GetCapabilityForSize(
      int width,
      int height);
  }
}