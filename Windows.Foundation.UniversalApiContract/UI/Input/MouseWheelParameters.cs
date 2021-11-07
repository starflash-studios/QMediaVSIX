// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.MouseWheelParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Provides properties associated with the button wheel of a mouse device.</summary>
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MouseWheelParameters : IMouseWheelParameters
  {
    /// <summary>Gets or sets the conversion factors for both character width and line height units, in device-independent pixel (DIP).</summary>
    /// <returns>The conversion factors for the character width (x) and line height (y).</returns>
    public extern Point CharTranslation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the change in scale associated with input from the wheel button of a mouse.</summary>
    /// <returns>The relative change in scale, in degrees.</returns>
    public extern float DeltaScale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the change in the angle of rotation associated with input from the wheel button of a mouse.</summary>
    /// <returns>A value between 0.0 and 359.0 in degrees of rotation. The default value is 0.0.</returns>
    public extern float DeltaRotationAngle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the conversion factors for both page width and height units, in device-independent pixel (DIP).</summary>
    /// <returns>The conversion factors for the page width (x) and height (y).</returns>
    public extern Point PageTranslation { [MethodImpl] get; [MethodImpl] set; }
  }
}
