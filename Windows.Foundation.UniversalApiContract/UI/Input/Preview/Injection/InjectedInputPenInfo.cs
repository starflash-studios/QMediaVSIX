// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputPenInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Represents programmatically generated pen input.</summary>
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class InjectedInputPenInfo : IInjectedInputPenInfo
  {
    /// <summary>Creates a new InjectedInputPenInfo object that is used to specify the pen input to inject.</summary>
    [MethodImpl]
    public extern InjectedInputPenInfo();

    /// <summary>Gets or sets basic pointer info common to pen input.</summary>
    /// <returns>The pointer info.</returns>
    public extern InjectedInputPointerInfo PointerInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the pen button options.</summary>
    /// <returns>The pen button states.</returns>
    public extern InjectedInputPenButtons PenButtons { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the pen states used to simulate pen input.</summary>
    /// <returns>The pen states used to simulate pen input.</returns>
    public extern InjectedInputPenParameters PenParameters { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the force exerted by the pointer device on the surface of the digitizer.</summary>
    /// <returns>The pen contact force exerted on the digitizer surface, normalized to a range between 0 and 1024. The default is 0.</returns>
    public extern double Pressure { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the clockwise rotation, or twist, of the pointer.</summary>
    /// <returns>The clockwise rotation, or twist, of the pointer normalized to a range between 0 and 359. The default is 0.</returns>
    public extern double Rotation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the angle of tilt of the pointer along the x-axis.</summary>
    /// <returns>The angle of tilt of the pointer along the x-axis in a range of -90 to +90, with a positive value indicating a tilt to the right. The default is 0.</returns>
    public extern int TiltX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the angle of tilt of the pointer along the y-axis.</summary>
    /// <returns>The angle of tilt of the pointer along the y-axis in a range of -90 to +90, with a positive value indicating a tilt toward the user. The default is 0.</returns>
    public extern int TiltY { [MethodImpl] get; [MethodImpl] set; }
  }
}
