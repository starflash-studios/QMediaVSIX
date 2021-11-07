// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Diagnostics.CompositionDebugSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Diagnostics
{
  /// <summary>Hosts diagnostic and debugging features such as heatmaps.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772165)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Static(typeof (ICompositionDebugSettingsStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class CompositionDebugSettings : ICompositionDebugSettings
  {
    /// <summary>Gets the heatmaps for this debug settings instance.</summary>
    /// <returns>The heatmaps for this debug settings instance.</returns>
    public extern CompositionDebugHeatMaps HeatMaps { [MethodImpl] get; }

    /// <summary>Attempts to get an instance of CompositionDebugSettings for the specified compositor.</summary>
    /// <param name="compositor">The compositor to get debug settings for.</param>
    /// <returns>An instance of composition debug settings.</returns>
    [MethodImpl]
    public static extern CompositionDebugSettings TryGetSettings(
      Compositor compositor);
  }
}
