// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapInteractionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Specifies if the map responds to a touch gesture and if the corresponding UI control appears on the map.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MapInteractionMode
  {
    /// <summary>Map UI control, mouse, keyboard, pen, and touch input are enabled based on the type of device that your app is running on.</summary>
    Auto = 0,
    /// <summary>Map UI control and touch input are disabled.</summary>
    Disabled = 1,
    /// <summary>Map responds to touch input only; the corresponding UI control is not visible. Use PointerAndKeyboard, if you want all forms of pointer input.</summary>
    GestureOnly = 2,
    /// <summary>Map responds to mouse, pen, touch and keyboard.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] PointerAndKeyboard = 2,
    /// <summary>Map responds to the UI control only; the corresponding touch input is disabled.</summary>
    ControlOnly = 3,
    /// <summary>Map UI control and touch input are enabled. Pointer and keyboard are not.</summary>
    GestureAndControl = 4,
    /// <summary>All forms of input are enabled including mouse, pen, touch, keyboard, and Map UI control.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] PointerKeyboardAndControl = 4,
    /// <summary>Map responds to mouse, pen, or touch only.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] PointerOnly = 5,
  }
}
