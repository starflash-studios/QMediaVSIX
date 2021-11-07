// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.SettingsFlyoutTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a SettingsFlyout control. Not intended for general use.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SettingsFlyoutTemplateSettings : 
    DependencyObject,
    ISettingsFlyoutTemplateSettings
  {
    /// <summary>Gets the brush that fills the background of the SettingsFlyout header area.</summary>
    /// <returns>The brush that fills the background of the SettingsFlyout header area.</returns>
    public extern Brush HeaderBackground { [MethodImpl] get; }

    /// <summary>Gets the brush that renders the header text of the SettingsFlyout.</summary>
    /// <returns>The brush that renders the header text of the SettingsFlyout.</returns>
    public extern Brush HeaderForeground { [MethodImpl] get; }

    /// <summary>Gets the brush that fills the border area of the SettingsFlyout.</summary>
    /// <returns>The brush that fills the border area of the SettingsFlyout.</returns>
    public extern Brush BorderBrush { [MethodImpl] get; }

    /// <summary>Gets the thickness of the SettingsFlyout border.</summary>
    /// <returns>The thickness of the SettingsFlyout border.</returns>
    public extern Thickness BorderThickness { [MethodImpl] get; }

    /// <summary>Gets the source image for the SettingsFlyout icon.</summary>
    /// <returns>The source image for the SettingsFlyout icon.</returns>
    public extern ImageSource IconSource { [MethodImpl] get; }

    /// <summary>Gets the collection of content transitions used by the SettingsFlyout.</summary>
    /// <returns>The collection of content transitions used by the SettingsFlyout.</returns>
    public extern TransitionCollection ContentTransitions { [MethodImpl] get; }
  }
}
