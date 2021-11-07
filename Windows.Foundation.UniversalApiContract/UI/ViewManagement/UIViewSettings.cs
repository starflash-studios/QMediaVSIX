// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.UIViewSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Represents UI states and behaviors associated with the device mode (Tablet or Desktop) and input device type.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IUIViewSettingsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UIViewSettings : IUIViewSettings
  {
    /// <summary>Gets a value that indicates whether the device UI is optimized for touch input or mouse input.</summary>
    /// <returns>A value that indicates the input type (mouse or touch) the device UI is optimized for.</returns>
    public extern UserInteractionMode UserInteractionMode { [MethodImpl] get; }

    /// <summary>Gets the UI states and behaviors associated with the device mode (Tablet or Desktop) for the active app.</summary>
    /// <returns>A UIViewSettings instance that can be used to get and set view settings properties.</returns>
    [MethodImpl]
    public static extern UIViewSettings GetForCurrentView();
  }
}
