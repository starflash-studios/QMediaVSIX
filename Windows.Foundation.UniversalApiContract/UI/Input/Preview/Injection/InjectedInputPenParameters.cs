// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputPenParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Specifies the pen states used to simulate pen input through InjectedInputPenInfo.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Flags]
  public enum InjectedInputPenParameters : uint
  {
    /// <summary>No pen state reported. Default.</summary>
    None = 0,
    /// <summary>The pen contact pressure on the digitizer surface, normalized to a range between 0 and 1024. The default is 0 if the device does not report pressure.</summary>
    Pressure = 1,
    /// <summary>The clockwise rotation, or twist, of the pointer normalized in a range of 0 to 359. The default is 0.</summary>
    Rotation = 2,
    /// <summary>The angle of tilt of the pointer along the x-axis in a range of -90 to +90, with a positive value indicating a tilt to the right. The default is 0.</summary>
    TiltX = 4,
    /// <summary>The angle of tilt of the pointer along the y-axis in a range of -90 to +90, with a positive value indicating a tilt toward the user. The default is 0.</summary>
    TiltY = 8,
  }
}
