// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.PointerVisualizationSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Provides access to the visual feedback settings for pointer input.</summary>
  [Static(typeof (IPointerVisualizationSettingsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PointerVisualizationSettings : IPointerVisualizationSettings
  {
    /// <summary>Gets or sets a value that indicates whether visual feedback is enabled when a pointer contact is detected.</summary>
    /// <returns>True if feedback is enabled; otherwise false. The default value is true.</returns>
    public extern bool IsContactFeedbackEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether visual feedback is enabled for pen/stylus input when the barrel button is pressed.</summary>
    /// <returns>True if feedback is enabled; otherwise false. The default value is true.</returns>
    public extern bool IsBarrelButtonFeedbackEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets a PointerVisualizationSettings object associated with the current app.</summary>
    /// <returns>The PointerVisualizationSettings object associated with the current app.</returns>
    [MethodImpl]
    public static extern PointerVisualizationSettings GetForCurrentView();
  }
}
