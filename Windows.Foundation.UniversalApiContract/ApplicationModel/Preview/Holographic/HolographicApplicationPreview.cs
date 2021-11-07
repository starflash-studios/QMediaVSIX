// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Preview.Holographic.HolographicApplicationPreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Preview.Holographic
{
  /// <summary>Provides preview functionality that let apps interact with the holographic shell, allowing the user to see content in the world around them.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHolographicApplicationPreviewStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public static class HolographicApplicationPreview
  {
    /// <summary>Gets whether the current app view will display in a Mixed Reality headset.</summary>
    /// <returns>Whether the current view will display in a headset.</returns>
    [MethodImpl]
    public static extern bool IsCurrentViewPresentedOnHolographicDisplay();

    /// <summary>Gets whether a given app activation is targeted at the holographic shell.</summary>
    /// <param name="activatedEventArgs">The app activation to inspect.</param>
    /// <returns>Whether the activation is targeted at the holographic shell.</returns>
    [MethodImpl]
    public static extern bool IsHolographicActivation(IActivatedEventArgs activatedEventArgs);
  }
}
