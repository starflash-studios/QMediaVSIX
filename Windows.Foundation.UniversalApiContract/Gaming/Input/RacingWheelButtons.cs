// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.RacingWheelButtons
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>Specifies the racing wheel button type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Flags]
  public enum RacingWheelButtons : uint
  {
    /// <summary>No button.</summary>
    None = 0,
    /// <summary>Gear shifted down.</summary>
    PreviousGear = 1,
    /// <summary>Gear shifted up.</summary>
    NextGear = 2,
    /// <summary>D-pad up.</summary>
    DPadUp = 4,
    /// <summary>D-pad down.</summary>
    DPadDown = 8,
    /// <summary>D-pad left.</summary>
    DPadLeft = 16, // 0x00000010
    /// <summary>D-pad right.</summary>
    DPadRight = 32, // 0x00000020
    /// <summary>Button 1.</summary>
    Button1 = 64, // 0x00000040
    /// <summary>Button 2.</summary>
    Button2 = 128, // 0x00000080
    /// <summary>Button 3.</summary>
    Button3 = 256, // 0x00000100
    /// <summary>Button 4.</summary>
    Button4 = 512, // 0x00000200
    /// <summary>Button 5.</summary>
    Button5 = 1024, // 0x00000400
    /// <summary>Button 6.</summary>
    Button6 = 2048, // 0x00000800
    /// <summary>Button 7.</summary>
    Button7 = 4096, // 0x00001000
    /// <summary>Button 8.</summary>
    Button8 = 8192, // 0x00002000
    /// <summary>Button 9.</summary>
    Button9 = 16384, // 0x00004000
    /// <summary>Button 10.</summary>
    Button10 = 32768, // 0x00008000
    /// <summary>Button 11.</summary>
    Button11 = 65536, // 0x00010000
    /// <summary>Button 12.</summary>
    Button12 = 131072, // 0x00020000
    /// <summary>Button 13.</summary>
    Button13 = 262144, // 0x00040000
    /// <summary>Button 14.</summary>
    Button14 = 524288, // 0x00080000
    /// <summary>Button 15.</summary>
    Button15 = 1048576, // 0x00100000
    /// <summary>Button 16.</summary>
    Button16 = 2097152, // 0x00200000
  }
}
