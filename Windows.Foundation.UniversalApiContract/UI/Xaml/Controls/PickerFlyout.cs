// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PickerFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a custom picker control. (Not recommended for Universal Windows Platform (UWP) app. See Flyout.)</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [global::Windows.UI.Xaml.Markup.ContentProperty(Name = "Content")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPickerFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PickerFlyout : PickerFlyoutBase, IPickerFlyout
  {
    /// <summary>Initializes a new instance of the PickerFlyout class.</summary>
    [MethodImpl]
    public extern PickerFlyout();

    /// <summary>Gets or sets the content that is contained within the picker.</summary>
    /// <returns>The content of the user control.</returns>
    public extern UIElement Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the confirmation buttons are visible.</summary>
    /// <returns>True of the confirmation buttons are visible; Otherwise, false.</returns>
    public extern bool ConfirmationButtonsVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the user has tapped a confirmation button to confirm the selection.</summary>
    public extern event TypedEventHandler<PickerFlyout, PickerConfirmedEventArgs> Confirmed;

    /// <summary>Begins an asynchronous operation to show the flyout placed in relation to the specified element.</summary>
    /// <param name="target">The element to use as the flyout's placement target.</param>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowAtAsync(FrameworkElement target);

    /// <summary>Gets the identifier for the Content dependency property.</summary>
    /// <returns>The identifier for the Content dependency property.</returns>
    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the ConfirmationButtonsVisible dependency property.</summary>
    /// <returns>The identifier of the ConfirmationButtonsVisible dependency property.</returns>
    public static extern DependencyProperty ConfirmationButtonsVisibleProperty { [MethodImpl] get; }
  }
}
