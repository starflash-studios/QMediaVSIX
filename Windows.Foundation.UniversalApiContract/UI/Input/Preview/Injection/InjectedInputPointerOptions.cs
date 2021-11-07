// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputPointerOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Specifies the various options, or modifiers, used to simulate pointer input through InjectedInputMouseInfo, InjectedInputPenInfo, and InjectedInputTouchInfo.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Flags]
  public enum InjectedInputPointerOptions : uint
  {
    /// <summary>No pointer modifier. Default.</summary>
    None = 0,
    /// <summary>Indicates the arrival of a new pointer.</summary>
    New = 1,
    /// <summary>Indicates that the pointer continues to exist. When this flag is not set, it indicates the pointer has left detection range.</summary>
    InRange = 2,
    /// <summary>Indicates that the pointer is in contact with the digitizer surface or area. When this flag is not set, it indicates a hovering pointer.</summary>
    InContact = 4,
    /// <summary>Indicates a primary action.</summary>
    FirstButton = 16, // 0x00000010
    /// <summary>Indicates a secondary action.</summary>
    SecondButton = 32, // 0x00000020
    /// <summary>Indicates that the pointer can perform actions beyond those available to non-primary pointers. For example, when a primary pointer makes contact with a window’s surface, it might provide the window an opportunity to activate.</summary>
    Primary = 8192, // 0x00002000
    /// <summary>Indicates a suggestion from the source device about whether the pointer represents an intended or accidental interaction, which is especially relevant for touch pointers where an accidental interaction (such as with the palm of the hand) can trigger input. The presence of this flag indicates that the source device has high confidence that this input is part of an intended interaction.</summary>
    Confidence = 16384, // 0x00004000
    /// <summary>Indicates that the pointer is departing in an abnormal manner, such as when the system receives invalid input for the pointer or when a device with active pointers departs abruptly. If the application receiving the input is in a position to do so, it should treat the interaction as not completed and reverse any effects of the pointer.</summary>
    Canceled = 32768, // 0x00008000
    /// <summary>Indicates that this pointer made contact with the digitizer surface. A touch pointer has this flag set when it is in contact with the digitizer surface.</summary>
    PointerDown = 65536, // 0x00010000
    /// <summary>Indicates a simple update that does not include pointer state changes.</summary>
    Update = 131072, // 0x00020000
    /// <summary>Indicates that this pointer ended contact with the digitizer surface. A touch pointer has this flag set when it ends contact with the digitizer surface.</summary>
    PointerUp = 262144, // 0x00040000
    /// <summary>Indicates that this pointer was captured by (associated with) another element and the original element has lost capture.</summary>
    CaptureChanged = 2097152, // 0x00200000
  }
}
