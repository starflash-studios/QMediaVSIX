// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.DisplayMonitorPhysicalConnectorKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display
{
  /// <summary>Defines constants that specify a physical connector standard used to connect a display.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum DisplayMonitorPhysicalConnectorKind
  {
    /// <summary>Indicates that the physical connector standard is not known.</summary>
    Unknown,
    /// <summary>Indicates that the physical connector standard is HD15 (also known as a VGA connector).</summary>
    HD15,
    /// <summary>Indicates that the physical connector standard is that of an analog television (also known as component video).</summary>
    AnalogTV,
    /// <summary>Indicates that the physical connector standard is Digital Visual Interface (DVI).</summary>
    Dvi,
    /// <summary>Indicates that the physical connector standard is High-Definition Multimedia Interface (HDMI).</summary>
    Hdmi,
    /// <summary>Indicates that the physical connector standard is low-voltage differential signaling (LVDS).</summary>
    Lvds,
    /// <summary>Indicates that the physical connector standard is serial digital interface (SDI).</summary>
    Sdi,
    /// <summary>Indicates that the physical connector standard is DisplayPort.</summary>
    DisplayPort,
  }
}
