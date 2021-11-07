// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.LampArrayUpdateRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Lights.Effects
{
  /// <summary>Provides event data for the UpdateRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LampArrayUpdateRequestedEventArgs : ILampArrayUpdateRequestedEventArgs
  {
    /// <summary>Gets the time since the effect was started.</summary>
    /// <returns>Time value of the time since the effect started.</returns>
    public extern TimeSpan SinceStarted { [MethodImpl] get; }

    /// <summary>Sets every lamp index specified in the effect to the desired color.</summary>
    /// <param name="desiredColor">Desired color to set every lamp to.</param>
    [MethodImpl]
    public extern void SetColor(Color desiredColor);

    /// <summary>Sets the lamp corresponding to the index to the desired color.</summary>
    /// <param name="lampIndex">The lamp index.</param>
    /// <param name="desiredColor">The desired color.</param>
    [MethodImpl]
    public extern void SetColorForIndex(int lampIndex, Color desiredColor);

    /// <summary>Sets all lamps specified to the same color.</summary>
    /// <param name="desiredColor">The desired color.</param>
    /// <param name="lampIndexes">Array of lamp indexes to set.</param>
    [MethodImpl]
    public extern void SetSingleColorForIndices(Color desiredColor, int[] lampIndexes);

    /// <summary>Sets the color for multiple lamps. Position within each array maps lamp index to desired color.</summary>
    /// <param name="desiredColors">Array of desired colors.</param>
    /// <param name="lampIndexes">Array of corresponding lamp indexes to modify.</param>
    [MethodImpl]
    public extern void SetColorsForIndices(Color[] desiredColors, int[] lampIndexes);
  }
}
