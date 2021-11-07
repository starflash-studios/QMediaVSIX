// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerMenu
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Represents the integrated menu of contextual tools associated with the RadialController object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  public sealed class RadialControllerMenu : IRadialControllerMenu
  {
    /// <summary>Gets the collection of custom tools on the RadialController menu. Built-in tools are not included.</summary>
    /// <returns>The collection of custom tools (RadialControllerMenuItem ) on the RadialController menu.</returns>
    public extern IVector<RadialControllerMenuItem> Items { [MethodImpl] get; }

    /// <summary>Gets or sets whether custom tools are displayed on the RadialController menu.</summary>
    /// <returns>**true** if the menu displays custom tools; otherwise **false**.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Retrieves the active custom tool from the RadialController menu .</summary>
    /// <returns>The active custom tool. Null if a custom tool is not active.</returns>
    [MethodImpl]
    public extern RadialControllerMenuItem GetSelectedMenuItem();

    /// <summary>Selects and activates the specified custom tool from the RadialController menu.</summary>
    /// <param name="menuItem">The custom tool to select.</param>
    [MethodImpl]
    public extern void SelectMenuItem(RadialControllerMenuItem menuItem);

    /// <summary>Attempts to select and activate the previously selected tool from the RadialController menu.</summary>
    /// <returns>**true** if the previously selected tool can be selected and activated; otherwise **false**.</returns>
    [MethodImpl]
    public extern bool TrySelectPreviouslySelectedMenuItem();
  }
}
