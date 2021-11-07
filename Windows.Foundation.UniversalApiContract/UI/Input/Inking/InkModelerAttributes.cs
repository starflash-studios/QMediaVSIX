// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkModelerAttributes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Manages which types of ink modeler attributes can be processed by the InkPresenter object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772165)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class InkModelerAttributes : IInkModelerAttributes, IInkModelerAttributes2
  {
    /// <summary>Gets or sets the amount of time into the future used to predict the expected location of the input pointer.</summary>
    /// <returns>The time in milliseconds. The default is 15 ms, with a valid range between 0 to 20 ms.</returns>
    public extern TimeSpan PredictionTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the scale transform for the coordinate space of the ink stroke.</summary>
    /// <returns>The scale factor in himetric units (one thousandth of a centimeter, and independent of the display or screen resolution).</returns>
    public extern float ScalingFactor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether pen velocity is used in combination with pressure on the inking surface to calculate final pressure value.</summary>
    /// <returns>True, if pen velocity is used. Otherwise, false.</returns>
    public extern bool UseVelocityBasedPressure { [MethodImpl] get; [MethodImpl] set; }
  }
}
