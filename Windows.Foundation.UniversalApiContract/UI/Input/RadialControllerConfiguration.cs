// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Provides configuration details for the RadialController menu.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [Static(typeof (IRadialControllerConfigurationStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRadialControllerConfigurationStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RadialControllerConfiguration : 
    IRadialControllerConfiguration,
    IRadialControllerConfiguration2
  {
    [MethodImpl]
    public extern void SetDefaultMenuItems(
      IIterable<RadialControllerSystemMenuItemKind> buttons);

    /// <summary>Restores the RadialController menu to the default configuration.</summary>
    [MethodImpl]
    public extern void ResetToDefaultMenuItems();

    /// <summary>Attempts to select and activate a tool from the collection of built-in RadialController tools supported for the current app context.</summary>
    /// <param name="type">The built-in tool to select and activate.</param>
    /// <returns>**true** if the tool can be selected; otherwise **false**.</returns>
    [MethodImpl]
    public extern bool TrySelectDefaultMenuItem(RadialControllerSystemMenuItemKind type);

    /// <summary>Gets or sets the RadialController to activate when the RadialController menu is suppressed.</summary>
    /// <returns>
    /// </returns>
    public extern RadialController ActiveControllerWhenMenuIsSuppressed { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the RadialController menu can be displayed.</summary>
    /// <returns>**true** if the menu is suppressed. Otherwise, **false**.</returns>
    public extern bool IsMenuSuppressed { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the RadialController object is bound to the main application process rather than a specific app view (or top-level window). </summary>
    /// <returns>The RadialController object to bind to the active application.</returns>
    public static extern RadialController AppController { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the RadialController object is enabled as an  AppController and controller events can be handled by your app.</summary>
    /// <returns>**true** if enabled. Otherwise, **false**. The default is **false**.</returns>
    public static extern bool IsAppControllerEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Retrieves a RadialControllerConfiguration object bound to the active application.</summary>
    /// <returns>The RadialControllerConfiguration object bound to the active application.</returns>
    [MethodImpl]
    public static extern RadialControllerConfiguration GetForCurrentView();
  }
}
