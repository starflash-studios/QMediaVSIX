// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.PickerFlyoutBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents a base class for picker controls.</summary>
  [Static(typeof (IPickerFlyoutBaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IPickerFlyoutBaseFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public class PickerFlyoutBase : FlyoutBase, IPickerFlyoutBase, IPickerFlyoutBaseOverrides
  {
    /// <summary>Provides base-class initialization behavior for classes that are derived from the PickerFlyoutBase class.</summary>
    [MethodImpl]
    protected extern PickerFlyoutBase();

    [MethodImpl]
    extern void IPickerFlyoutBaseOverrides.OnConfirmed();

    [MethodImpl]
    extern bool IPickerFlyoutBaseOverrides.ShouldShowConfirmationButtons();

    /// <summary>Gets the identifier for the attached title property.</summary>
    /// <returns>The identifier for the attached title property.</returns>
    public static extern DependencyProperty TitleProperty { [MethodImpl] get; }

    /// <summary>Gets the title displayed on the picker control.</summary>
    /// <param name="element">The dependency object for which to get the title.</param>
    /// <returns>The title displayed on the picker control.</returns>
    [MethodImpl]
    public static extern string GetTitle(DependencyObject element);

    /// <summary>Sets the title displayed on a picker control.</summary>
    /// <param name="element">The dependency object for which to set the title.</param>
    /// <param name="value">The title you want to display.</param>
    [MethodImpl]
    public static extern void SetTitle(DependencyObject element, string value);
  }
}
