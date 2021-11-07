// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Provides the ability to check system hardware capabilities so that Visual Layer Effects may be scaled accordingly. This allows you to ensure that your application's use of rendering-intensive operations is tailored to match the device's capabilities, providing optimum performance and pleasant visual results.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [Static(typeof (ICompositionCapabilitiesStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositionCapabilities : ICompositionCapabilities
  {
    /// <summary>Indicates whether effects are supported.</summary>
    /// <returns>Returns a boolean indicating whether effects are supported.</returns>
    [MethodImpl]
    public extern bool AreEffectsSupported();

    /// <summary>Indicates whether fast effects are supported.</summary>
    /// <returns>Returns a boolean indicating whether fast effects are supported.</returns>
    [MethodImpl]
    public extern bool AreEffectsFast();

    /// <summary>Event triggered when the supported composition capabilities changes.</summary>
    public extern event TypedEventHandler<CompositionCapabilities, object> Changed;

    /// <summary>Gets the supported composition capabilities for the current view.</summary>
    /// <returns>Returns the supported composition capabilities for the current view.</returns>
    [MethodImpl]
    public static extern CompositionCapabilities GetForCurrentView();
  }
}
