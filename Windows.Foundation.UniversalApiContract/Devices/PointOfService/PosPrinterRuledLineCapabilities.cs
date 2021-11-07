// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterRuledLineCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Describes the capabilities of the point-of-service printer to draw ruled lines.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PosPrinterRuledLineCapabilities : uint
  {
    /// <summary>The printer cannot draw ruled lines.</summary>
    None = 0,
    /// <summary>The printer can draw ruled horizontal lines.</summary>
    Horizontal = 1,
    /// <summary>The printer can draw ruled vertical lines.</summary>
    Vertical = 2,
  }
}
