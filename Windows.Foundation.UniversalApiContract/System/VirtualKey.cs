// Decompiled with JetBrains decompiler
// Type: Windows.System.VirtualKey
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Specifies the values for each virtual key.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VirtualKey
  {
    /// <summary>No virtual key value.</summary>
    None = 0,
    /// <summary>The left mouse button.</summary>
    LeftButton = 1,
    /// <summary>The right mouse button.</summary>
    RightButton = 2,
    /// <summary>The cancel key or button</summary>
    Cancel = 3,
    /// <summary>The middle mouse button.</summary>
    MiddleButton = 4,
    /// <summary>An additional "extended" device key or button (for example, an additional mouse button).</summary>
    XButton1 = 5,
    /// <summary>An additional "extended" device key or button (for example, an additional mouse button).</summary>
    XButton2 = 6,
    /// <summary>The virtual back key or button.</summary>
    Back = 8,
    /// <summary>The Tab key.</summary>
    Tab = 9,
    /// <summary>The Clear key or button.</summary>
    Clear = 12, // 0x0000000C
    /// <summary>The Enter key.</summary>
    Enter = 13, // 0x0000000D
    /// <summary>The Shift key. This is the general Shift case, applicable to key layouts with only one Shift key or that do not need to differentiate between left Shift and right Shift keystrokes.</summary>
    Shift = 16, // 0x00000010
    /// <summary>The Ctrl key. This is the general Ctrl case, applicable to key layouts with only one Ctrl key or that do not need to differentiate between left Ctrl and right Ctrl keystrokes.</summary>
    Control = 17, // 0x00000011
    /// <summary>The menu key or button.</summary>
    Menu = 18, // 0x00000012
    /// <summary>The Pause key or button.</summary>
    Pause = 19, // 0x00000013
    /// <summary>The Caps Lock key or button.</summary>
    CapitalLock = 20, // 0x00000014
    /// <summary>The Hangul symbol key-shift button.</summary>
    Hangul = 21, // 0x00000015
    /// <summary>The Kana symbol key-shift button</summary>
    Kana = 21, // 0x00000015
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] ImeOn = 22, // 0x00000016
    /// <summary>The Junja symbol key-shift button.</summary>
    Junja = 23, // 0x00000017
    /// <summary>The Final symbol key-shift button.</summary>
    Final = 24, // 0x00000018
    /// <summary>The Hanja symbol key shift button.</summary>
    Hanja = 25, // 0x00000019
    /// <summary>The Kanji symbol key-shift button.</summary>
    Kanji = 25, // 0x00000019
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] ImeOff = 26, // 0x0000001A
    /// <summary>The Esc key.</summary>
    Escape = 27, // 0x0000001B
    /// <summary>The convert button or key.</summary>
    Convert = 28, // 0x0000001C
    /// <summary>The nonconvert button or key.</summary>
    NonConvert = 29, // 0x0000001D
    /// <summary>The accept button or key.</summary>
    Accept = 30, // 0x0000001E
    /// <summary>The mode change key.</summary>
    ModeChange = 31, // 0x0000001F
    /// <summary>The Spacebar key or button.</summary>
    Space = 32, // 0x00000020
    /// <summary>The Page Up key.</summary>
    PageUp = 33, // 0x00000021
    /// <summary>The Page Down key.</summary>
    PageDown = 34, // 0x00000022
    /// <summary>The End key.</summary>
    End = 35, // 0x00000023
    /// <summary>The Home key.</summary>
    Home = 36, // 0x00000024
    /// <summary>The Left Arrow key.</summary>
    Left = 37, // 0x00000025
    /// <summary>The Up Arrow key.</summary>
    Up = 38, // 0x00000026
    /// <summary>The Right Arrow key.</summary>
    Right = 39, // 0x00000027
    /// <summary>The Down Arrow key.</summary>
    Down = 40, // 0x00000028
    /// <summary>The Select key or button.</summary>
    Select = 41, // 0x00000029
    /// <summary>The Print key or button.</summary>
    Print = 42, // 0x0000002A
    /// <summary>The execute key or button.</summary>
    Execute = 43, // 0x0000002B
    /// <summary>The snapshot key or button.</summary>
    Snapshot = 44, // 0x0000002C
    /// <summary>The Insert key.</summary>
    Insert = 45, // 0x0000002D
    /// <summary>The Delete key.</summary>
    Delete = 46, // 0x0000002E
    /// <summary>The Help key or button.</summary>
    Help = 47, // 0x0000002F
    /// <summary>The number "0" key.</summary>
    Number0 = 48, // 0x00000030
    /// <summary>The number "1" key.</summary>
    Number1 = 49, // 0x00000031
    /// <summary>The number "2" key.</summary>
    Number2 = 50, // 0x00000032
    /// <summary>The number "3" key.</summary>
    Number3 = 51, // 0x00000033
    /// <summary>The number "4" key.</summary>
    Number4 = 52, // 0x00000034
    /// <summary>The number "5" key.</summary>
    Number5 = 53, // 0x00000035
    /// <summary>The number "6" key.</summary>
    Number6 = 54, // 0x00000036
    /// <summary>The number "7" key.</summary>
    Number7 = 55, // 0x00000037
    /// <summary>The number "8" key.</summary>
    Number8 = 56, // 0x00000038
    /// <summary>The number "9" key.</summary>
    Number9 = 57, // 0x00000039
    /// <summary>The letter "A" key.</summary>
    A = 65, // 0x00000041
    /// <summary>The letter "B" key.</summary>
    B = 66, // 0x00000042
    /// <summary>The letter "C" key.</summary>
    C = 67, // 0x00000043
    /// <summary>The letter "D" key.</summary>
    D = 68, // 0x00000044
    /// <summary>The letter "E" key.</summary>
    E = 69, // 0x00000045
    /// <summary>The letter "F" key.</summary>
    F = 70, // 0x00000046
    /// <summary>The letter "G" key.</summary>
    G = 71, // 0x00000047
    /// <summary>The letter "H" key.</summary>
    H = 72, // 0x00000048
    /// <summary>The letter "I" key.</summary>
    I = 73, // 0x00000049
    /// <summary>The letter "J" key.</summary>
    J = 74, // 0x0000004A
    /// <summary>The letter "K" key.</summary>
    K = 75, // 0x0000004B
    /// <summary>The letter "L" key.</summary>
    L = 76, // 0x0000004C
    /// <summary>The letter "M" key.</summary>
    M = 77, // 0x0000004D
    /// <summary>The letter "N" key.</summary>
    N = 78, // 0x0000004E
    /// <summary>The letter "O" key.</summary>
    O = 79, // 0x0000004F
    /// <summary>The letter "P" key.</summary>
    P = 80, // 0x00000050
    /// <summary>The letter "Q" key.</summary>
    Q = 81, // 0x00000051
    /// <summary>The letter "R" key.</summary>
    R = 82, // 0x00000052
    /// <summary>The letter "S" key.</summary>
    S = 83, // 0x00000053
    /// <summary>The letter "T" key.</summary>
    T = 84, // 0x00000054
    /// <summary>The letter "U" key.</summary>
    U = 85, // 0x00000055
    /// <summary>The letter "V" key.</summary>
    V = 86, // 0x00000056
    /// <summary>The letter "W" key.</summary>
    W = 87, // 0x00000057
    /// <summary>The letter "X" key.</summary>
    X = 88, // 0x00000058
    /// <summary>The letter "Y" key.</summary>
    Y = 89, // 0x00000059
    /// <summary>The letter "Z" key.</summary>
    Z = 90, // 0x0000005A
    /// <summary>The left Windows key.</summary>
    LeftWindows = 91, // 0x0000005B
    /// <summary>The right Windows key.</summary>
    RightWindows = 92, // 0x0000005C
    /// <summary>The application key or button.</summary>
    Application = 93, // 0x0000005D
    /// <summary>The sleep key or button.</summary>
    Sleep = 95, // 0x0000005F
    /// <summary>The number "0" key as located on a numeric pad.</summary>
    NumberPad0 = 96, // 0x00000060
    /// <summary>The number "1" key as located on a numeric pad.</summary>
    NumberPad1 = 97, // 0x00000061
    /// <summary>The number "2" key as located on a numeric pad.</summary>
    NumberPad2 = 98, // 0x00000062
    /// <summary>The number "3" key as located on a numeric pad.</summary>
    NumberPad3 = 99, // 0x00000063
    /// <summary>The number "4" key as located on a numeric pad.</summary>
    NumberPad4 = 100, // 0x00000064
    /// <summary>The number "5" key as located on a numeric pad.</summary>
    NumberPad5 = 101, // 0x00000065
    /// <summary>The number "6" key as located on a numeric pad.</summary>
    NumberPad6 = 102, // 0x00000066
    /// <summary>The number "7" key as located on a numeric pad.</summary>
    NumberPad7 = 103, // 0x00000067
    /// <summary>The number "8" key as located on a numeric pad.</summary>
    NumberPad8 = 104, // 0x00000068
    /// <summary>The number "9" key as located on a numeric pad.</summary>
    NumberPad9 = 105, // 0x00000069
    /// <summary>The multiply (*) operation key as located on a numeric pad.</summary>
    Multiply = 106, // 0x0000006A
    /// <summary>The add (+) operation key as located on a numeric pad.</summary>
    Add = 107, // 0x0000006B
    /// <summary>The separator key as located on a numeric pad.</summary>
    Separator = 108, // 0x0000006C
    /// <summary>The subtract (-) operation key as located on a numeric pad.</summary>
    Subtract = 109, // 0x0000006D
    /// <summary>The decimal (.) key as located on a numeric pad.</summary>
    Decimal = 110, // 0x0000006E
    /// <summary>The divide (/) operation key as located on a numeric pad.</summary>
    Divide = 111, // 0x0000006F
    /// <summary>The F1 function key.</summary>
    F1 = 112, // 0x00000070
    /// <summary>The F2 function key.</summary>
    F2 = 113, // 0x00000071
    /// <summary>The F3 function key.</summary>
    F3 = 114, // 0x00000072
    /// <summary>The F4 function key.</summary>
    F4 = 115, // 0x00000073
    /// <summary>The F5 function key.</summary>
    F5 = 116, // 0x00000074
    /// <summary>The F6 function key.</summary>
    F6 = 117, // 0x00000075
    /// <summary>The F7 function key.</summary>
    F7 = 118, // 0x00000076
    /// <summary>The F8 function key.</summary>
    F8 = 119, // 0x00000077
    /// <summary>The F9 function key.</summary>
    F9 = 120, // 0x00000078
    /// <summary>The F10 function key.</summary>
    F10 = 121, // 0x00000079
    /// <summary>The F11 function key.</summary>
    F11 = 122, // 0x0000007A
    /// <summary>The F12 function key.</summary>
    F12 = 123, // 0x0000007B
    /// <summary>The F13 function key.</summary>
    F13 = 124, // 0x0000007C
    /// <summary>The F14 function key.</summary>
    F14 = 125, // 0x0000007D
    /// <summary>The F15 function key.</summary>
    F15 = 126, // 0x0000007E
    /// <summary>The F16 function key.</summary>
    F16 = 127, // 0x0000007F
    /// <summary>The F17 function key.</summary>
    F17 = 128, // 0x00000080
    /// <summary>The F18 function key.</summary>
    F18 = 129, // 0x00000081
    /// <summary>The F19 function key.</summary>
    F19 = 130, // 0x00000082
    /// <summary>The F20 function key.</summary>
    F20 = 131, // 0x00000083
    /// <summary>The F21 function key.</summary>
    F21 = 132, // 0x00000084
    /// <summary>The F22 function key.</summary>
    F22 = 133, // 0x00000085
    /// <summary>The F23 function key.</summary>
    F23 = 134, // 0x00000086
    /// <summary>The F24 function key.</summary>
    F24 = 135, // 0x00000087
    /// <summary>The navigation up button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationView = 136, // 0x00000088
    /// <summary>The navigation menu button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationMenu = 137, // 0x00000089
    /// <summary>The navigation up button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationUp = 138, // 0x0000008A
    /// <summary>The navigation down button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationDown = 139, // 0x0000008B
    /// <summary>The navigation left button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationLeft = 140, // 0x0000008C
    /// <summary>The navigation right button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationRight = 141, // 0x0000008D
    /// <summary>The navigation accept button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationAccept = 142, // 0x0000008E
    /// <summary>The navigation cancel button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NavigationCancel = 143, // 0x0000008F
    /// <summary>The Num Lock key.</summary>
    NumberKeyLock = 144, // 0x00000090
    /// <summary>The Scroll Lock (ScrLk) key.</summary>
    Scroll = 145, // 0x00000091
    /// <summary>The left Shift key.</summary>
    LeftShift = 160, // 0x000000A0
    /// <summary>The right Shift key.</summary>
    RightShift = 161, // 0x000000A1
    /// <summary>The left Ctrl key.</summary>
    LeftControl = 162, // 0x000000A2
    /// <summary>The right Ctrl key.</summary>
    RightControl = 163, // 0x000000A3
    /// <summary>The left menu key.</summary>
    LeftMenu = 164, // 0x000000A4
    /// <summary>The right menu key.</summary>
    RightMenu = 165, // 0x000000A5
    /// <summary>The go back key.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GoBack = 166, // 0x000000A6
    /// <summary>The go forward key.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GoForward = 167, // 0x000000A7
    /// <summary>The refresh key.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Refresh = 168, // 0x000000A8
    /// <summary>The stop key.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Stop = 169, // 0x000000A9
    /// <summary>The search key.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Search = 170, // 0x000000AA
    /// <summary>The favorites key.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Favorites = 171, // 0x000000AB
    /// <summary>The go home key.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GoHome = 172, // 0x000000AC
    /// <summary>The gamepad A button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadA = 195, // 0x000000C3
    /// <summary>The gamepad B button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadB = 196, // 0x000000C4
    /// <summary>The gamepad X button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadX = 197, // 0x000000C5
    /// <summary>The gamepad Y button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadY = 198, // 0x000000C6
    /// <summary>The gamepad right shoulder.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightShoulder = 199, // 0x000000C7
    /// <summary>The gamepad left shoulder.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftShoulder = 200, // 0x000000C8
    /// <summary>The gamepad left trigger.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftTrigger = 201, // 0x000000C9
    /// <summary>The gamepad right trigger.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightTrigger = 202, // 0x000000CA
    /// <summary>The gamepad d-pad up.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadDPadUp = 203, // 0x000000CB
    /// <summary>The gamepad d-pad down.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadDPadDown = 204, // 0x000000CC
    /// <summary>The gamepad d-pad left.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadDPadLeft = 205, // 0x000000CD
    /// <summary>The gamepad d-pad right.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadDPadRight = 206, // 0x000000CE
    /// <summary>The gamepad menu button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadMenu = 207, // 0x000000CF
    /// <summary>The gamepad view button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadView = 208, // 0x000000D0
    /// <summary>The gamepad left thumbstick button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftThumbstickButton = 209, // 0x000000D1
    /// <summary>The gamepad right thumbstick button.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightThumbstickButton = 210, // 0x000000D2
    /// <summary>The gamepad left thumbstick up.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftThumbstickUp = 211, // 0x000000D3
    /// <summary>The gamepad left thumbstick down.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftThumbstickDown = 212, // 0x000000D4
    /// <summary>The gamepad left thumbstick right.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftThumbstickRight = 213, // 0x000000D5
    /// <summary>The gamepad left thumbstick left.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadLeftThumbstickLeft = 214, // 0x000000D6
    /// <summary>The gamepad right thumbstick up.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightThumbstickUp = 215, // 0x000000D7
    /// <summary>The gamepad right thumbstick down.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightThumbstickDown = 216, // 0x000000D8
    /// <summary>The gamepad right thumbstick right.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightThumbstickRight = 217, // 0x000000D9
    /// <summary>The gamepad right thumbstick left.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GamepadRightThumbstickLeft = 218, // 0x000000DA
  }
}
