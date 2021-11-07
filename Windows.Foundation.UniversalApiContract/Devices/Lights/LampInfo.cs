// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.LampInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI;

namespace Windows.Devices.Lights
{
  /// <summary>Container of various properties of an individual lamp for a specific index.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LampInfo : ILampInfo
  {
    /// <summary>Zero based index of the lamp.  Every lamp is associated with one unique index.</summary>
    /// <returns>The lamp index.</returns>
    public extern int Index { [MethodImpl] get; }

    /// <summary>Purpose/s of the lamp.</summary>
    /// <returns>The lamp purposes.</returns>
    public extern LampPurposes Purposes { [MethodImpl] get; }

    /// <summary>3D position of the lamp relative to the origin of the bounding-box.</summary>
    /// <returns>The position of the lamp.</returns>
    public extern Vector3 Position { [MethodImpl] get; }

    /// <summary>The number of red intensities settable for this lamp.</summary>
    /// <returns>The count of red levels.</returns>
    public extern int RedLevelCount { [MethodImpl] get; }

    /// <summary>The number of green intensities settable for this lamp.</summary>
    /// <returns>The count of green levels.</returns>
    public extern int GreenLevelCount { [MethodImpl] get; }

    /// <summary>The number of blue intensities settable for this lamp.</summary>
    /// <returns>The count of blue levels.</returns>
    public extern int BlueLevelCount { [MethodImpl] get; }

    /// <summary>The number of color independent intensities settable for this lamp.</summary>
    /// <returns>The intensity value settable for the lamp.</returns>
    public extern int GainLevelCount { [MethodImpl] get; }

    /// <summary>If this lamp index has a fixed color, the color is returned; otherwise null.</summary>
    /// <returns>The lamp color.</returns>
    public extern IReference<Color> FixedColor { [MethodImpl] get; }

    /// <summary>Finds the nearest/closest matching color to the desired color, supported by this lamp.  Call this to know whether a specific color will be applied during (e.g.) LampArray.SetColor</summary>
    /// <param name="desiredColor">The color to find the nearest/closest.</param>
    /// <returns>The nearest/closest color supported by this lamp.</returns>
    [MethodImpl]
    public extern Color GetNearestSupportedColor(Color desiredColor);

    /// <summary>Time between the device receiving an update for a lamp and it emanating from the device.</summary>
    /// <returns>The time value between receiving an update and emanating from the device.</returns>
    public extern TimeSpan UpdateLatency { [MethodImpl] get; }
  }
}
