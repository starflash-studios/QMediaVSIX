// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.ResolutionScale
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Describes the scale factor of the immersive environment. The scale factor is determined by the operating system in response to high pixel density screens.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ResolutionScale
  {
    /// <summary>Specifies the scale of a display is invalid.</summary>
    Invalid = 0,
    /// <summary>Specifies the scale of a display as 100 percent. This percentage indicates a minimum screen resolution for Windows all up is 1024x768.</summary>
    Scale100Percent = 100, // 0x00000064
    /// <summary>This value isn't used.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale120Percent = 120, // 0x00000078
    /// <summary>Specifies the scale of a display as 125 percent.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale125Percent = 125, // 0x0000007D
    /// <summary>Specifies the scale of a display as 140 percent. This percentage indicates a minimum screen resolution to scale at 140 is 1440x1080.</summary>
    Scale140Percent = 140, // 0x0000008C
    /// <summary>Applies to Windows Phone 8.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale150Percent = 150, // 0x00000096
    /// <summary>Applies to Windows Phone 8.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale160Percent = 160, // 0x000000A0
    /// <summary>Specifies the scale of a display as 175 percent.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale175Percent = 175, // 0x000000AF
    /// <summary>Specifies the scale of a display as 180 percent. This percentage indicates a minimum screen resolution to scale at 180 is 1920x1440.</summary>
    Scale180Percent = 180, // 0x000000B4
    /// <summary>Specifies the scale of a display as 200 percent.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale200Percent = 200, // 0x000000C8
    /// <summary>This value isn't used.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale225Percent = 225, // 0x000000E1
    /// <summary>Specifies the scale of a display as 250 percent.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale250Percent = 250, // 0x000000FA
    /// <summary>Specifies the scale of a display as 300 percent.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale300Percent = 300, // 0x0000012C
    /// <summary>Specifies the scale of a display as 350 percent.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale350Percent = 350, // 0x0000015E
    /// <summary>Specifies the scale of a display as 400 percent.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale400Percent = 400, // 0x00000190
    /// <summary>Specifies the scale of a display as 450 percent.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale450Percent = 450, // 0x000001C2
    /// <summary>Specifies the scale of a display as 500 percent.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale500Percent = 500, // 0x000001F4
  }
}
