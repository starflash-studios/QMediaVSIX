// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputTouchParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Specifies the touch states used to simulate touch input through InjectedInputTouchInfo.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum InjectedInputTouchParameters : uint
  {
    /// <summary>No touch state reported. Default.</summary>
    None = 0,
    /// <summary>The screen coordinates of the bounding box that represents the touch contact area.</summary>
    Contact = 1,
    /// <summary>The counter-clockwise angle of rotation around the major axis of the pointer device (the z-axis, perpendicular to the surface of the digitizer).</summary>
    Orientation = 2,
    /// <summary>The force exerted by the pointer device on the surface of the digitizer.</summary>
    Pressure = 4,
  }
}
