// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.PointerUpdateKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Specifies the types of pointer updates that are supported by an application.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PointerUpdateKind
  {
    /// <summary>Pointer updates not identified by other PointerUpdateKind values.</summary>
    Other,
    /// <summary>Left button pressed.</summary>
    LeftButtonPressed,
    /// <summary>Left button released.</summary>
    LeftButtonReleased,
    /// <summary>Right button pressed.</summary>
    RightButtonPressed,
    /// <summary>Right button released.</summary>
    RightButtonReleased,
    /// <summary>Middle button pressed.</summary>
    MiddleButtonPressed,
    /// <summary>Middle button released.</summary>
    MiddleButtonReleased,
    /// <summary>XBUTTON1 pressed.</summary>
    XButton1Pressed,
    /// <summary>XBUTTON1 released.</summary>
    XButton1Released,
    /// <summary>XBUTTON2 pressed.</summary>
    XButton2Pressed,
    /// <summary>XBUTTON2 released.</summary>
    XButton2Released,
  }
}
