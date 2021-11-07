// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.FocusInputDeviceKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Specifies the input device types from which input events are received.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum FocusInputDeviceKind
  {
    /// <summary>No input. Used only when the focus is moved programmatically.</summary>
    None,
    /// <summary>Mouse input device.</summary>
    Mouse,
    /// <summary>Touch input device.</summary>
    Touch,
    /// <summary>Pen input device.</summary>
    Pen,
    /// <summary>Keyboard input device.</summary>
    Keyboard,
    /// <summary>Game controller/remote control input device.</summary>
    GameController,
  }
}
