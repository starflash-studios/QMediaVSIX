// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Represents programmatically generated touch input.</summary>
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class InjectedInputTouchInfo : IInjectedInputTouchInfo
  {
    /// <summary>Creates a new InjectedInputTouchInfo object that is used to specify the touch input to inject.</summary>
    [MethodImpl]
    public extern InjectedInputTouchInfo();

    /// <summary>Gets or sets the bounding box that represents the touch contact area.</summary>
    /// <returns>The contact area in device-independent pixel (DIP). The default is a 0-by-0 rectangle, centered around the pointer PixelLocation.</returns>
    public extern InjectedInputRectangle Contact { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the counter-clockwise angle of rotation around the major axis of the pointer device (the z-axis, perpendicular to the surface of the digitizer).</summary>
    /// <returns>The pointer orientation, with a value between 0 and 359, where 0 indicates a touch pointer aligned with the x-axis and pointing from left to right; increasing values indicate degrees of rotation in the counter-clockwise direction. The default is 0.</returns>
    public extern int Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets basic pointer info common to touch input.</summary>
    /// <returns>The pointer info.</returns>
    public extern InjectedInputPointerInfo PointerInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the force exerted by the pointer device on the surface of the digitizer.</summary>
    /// <returns>The touch contact force exerted on the digitizer surface, normalized to a range between 0 and 1024. The default is 0.</returns>
    public extern double Pressure { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the touch states used to simulate touch input.</summary>
    /// <returns>The touch states used to simulate touch input.</returns>
    public extern InjectedInputTouchParameters TouchParameters { [MethodImpl] get; [MethodImpl] set; }
  }
}
