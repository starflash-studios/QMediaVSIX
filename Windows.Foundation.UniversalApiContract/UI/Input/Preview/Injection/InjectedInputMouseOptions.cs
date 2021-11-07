// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputMouseOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Specifies the various options, or modifiers, used to simulate mouse input through InjectedInputMouseInfo.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Flags]
  public enum InjectedInputMouseOptions : uint
  {
    /// <summary>No mouse modifier. Default.</summary>
    None = 0,
    /// <summary>Move (coalesce move messages). If a mouse event occurs and the application has not yet processed the previous mouse event, the previous one is thrown away. See **MoveNoCoalesce**.</summary>
    Move = 1,
    /// <summary>Left mouse button pressed.</summary>
    LeftDown = 2,
    /// <summary>Left mouse button released.</summary>
    LeftUp = 4,
    /// <summary>Right mouse button pressed.</summary>
    RightDown = 8,
    /// <summary>Right mouse button released.</summary>
    RightUp = 16, // 0x00000010
    /// <summary>Middle mouse button pressed.</summary>
    MiddleDown = 32, // 0x00000020
    /// <summary>Middle mouse button released.</summary>
    MiddleUp = 64, // 0x00000040
    /// <summary>XBUTTON pressed.</summary>
    XDown = 128, // 0x00000080
    /// <summary>XBUTTON released.</summary>
    XUp = 256, // 0x00000100
    /// <summary>Mouse wheel.</summary>
    Wheel = 2048, // 0x00000800
    /// <summary>Mouse tilt wheel.</summary>
    HWheel = 4096, // 0x00001000
    /// <summary>Move (do not coalesce move messages). The application processes all mouse events since the previously processed mouse event. See **Move**.</summary>
    MoveNoCoalesce = 8192, // 0x00002000
    /// <summary>Map coordinates to the entire virtual desktop.</summary>
    VirtualDesk = 16384, // 0x00004000
    /// <summary>Normalized absolute coordinates between 0 and 65,535. If the flag is not set, relative data (the change in position since the last reported position) is used.</summary>
    Absolute = 32768, // 0x00008000
  }
}
