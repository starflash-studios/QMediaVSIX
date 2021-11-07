﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayDescriptorState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicate the state of a line display descriptor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum LineDisplayDescriptorState
  {
    /// <summary>Turns the descriptor off.</summary>
    Off,
    /// <summary>Turns the descriptor on.</summary>
    On,
    /// <summary>Sets the descriptor to blinking.</summary>
    Blink,
  }
}