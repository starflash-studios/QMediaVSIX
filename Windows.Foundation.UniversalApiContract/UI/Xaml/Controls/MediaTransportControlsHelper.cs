// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MediaTransportControlsHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides properties and methods to customize media transport controls.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaTransportControlsHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaTransportControlsHelper : IMediaTransportControlsHelper
  {
    /// <summary>Identifies the MediaTransportControlsHelper.DropoutOrder XAML attached property.</summary>
    /// <returns>The identifier for the MediaTransportControlsHelper.DropoutOrder XAML attached property.</returns>
    public static extern DependencyProperty DropoutOrderProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the MediaTransportControlsHelper.DropoutOrder XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The value to set. (The dropout priority of the control relative to other transport controls.)</returns>
    [MethodImpl]
    public static extern IReference<int> GetDropoutOrder(UIElement element);

    [MethodImpl]
    public static extern void SetDropoutOrder(UIElement element, IReference<int> value);
  }
}
