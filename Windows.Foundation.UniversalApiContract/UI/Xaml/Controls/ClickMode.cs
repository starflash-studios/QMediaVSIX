// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ClickMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Specifies when the Click event should be raised for a control.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum ClickMode
  {
    /// <summary>Specifies that the Click event should be raised when the left mouse button is pressed and released, and the mouse pointer is over the control. If you are using the keyboard, specifies that the Click event should be raised when the SPACEBAR or ENTER key is pressed and released, and the control has keyboard focus.</summary>
    Release,
    /// <summary>Specifies that the Click event should be raised when the mouse button is pressed and the mouse pointer is over the control. If you are using the keyboard, specifies that the Click event should be raised when the SPACEBAR or ENTER key is pressed and the control has keyboard focus.</summary>
    Press,
    /// <summary>Specifies that the Click event should be raised when the mouse pointer moves over the control.</summary>
    Hover,
  }
}
