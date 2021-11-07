// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.JumpListItemForegroundConverter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides the appropriate foreground Brush for elements in the item template of a jump list to bind to. The Brush reflects the current theme and accent color, and it's also used to shade empty-group jump list items. By default, the Brush matches built-in apps, but you can override that to suit your design needs using the Enabled and Disabled properties.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IJumpListItemForegroundConverterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class JumpListItemForegroundConverter : 
    DependencyObject,
    IJumpListItemForegroundConverter,
    IValueConverter
  {
    /// <summary>Initializes a new instance of the JumpListItemForegroundConverter class.</summary>
    [MethodImpl]
    public extern JumpListItemForegroundConverter();

    /// <summary>Gets or sets the brush to be used for the foreground when the group is not empty and the jump list item is enabled.</summary>
    /// <returns>The brush to be used for the foreground when the group is not empty and the jump list item is enabled.</returns>
    public extern Brush Enabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush to be used for the foreground when the group is empty and the jump list item is disabled.</summary>
    /// <returns>The brush to be used for the foreground when the group is empty and the jump list item is disabled.</returns>
    public extern Brush Disabled { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern object Convert(
      object value,
      TypeName targetType,
      object parameter,
      string language);

    [MethodImpl]
    public extern object ConvertBack(
      object value,
      TypeName targetType,
      object parameter,
      string language);

    /// <summary>Identifies the Enabled dependency property.</summary>
    /// <returns>The identifier for the Enabled dependency property.</returns>
    public static extern DependencyProperty EnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the Disabled dependency property.</summary>
    /// <returns>The identifier for the Disabled dependency property.</returns>
    public static extern DependencyProperty DisabledProperty { [MethodImpl] get; }
  }
}
