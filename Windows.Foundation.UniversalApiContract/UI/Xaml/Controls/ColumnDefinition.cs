// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ColumnDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines column-specific properties that apply to Grid objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IColumnDefinitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ColumnDefinition : DependencyObject, IColumnDefinition
  {
    /// <summary>Initializes a new instance of the ColumnDefinition class.</summary>
    [MethodImpl]
    public extern ColumnDefinition();

    /// <summary>Gets the calculated width of a ColumnDefinition element, or sets the GridLength value of a column that is defined by the ColumnDefinition.</summary>
    /// <returns>The GridLength that represents the width of the column. The default value is a GridLength representing a "1\*" sizing.</returns>
    public extern GridLength Width { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that represents the maximum width of a ColumnDefinition.</summary>
    /// <returns>A Double that represents the maximum width in pixels. The default is PositiveInfinity.</returns>
    public extern double MaxWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that represents the minimum width of a ColumnDefinition.</summary>
    /// <returns>A Double that represents the minimum width in pixels. The default is 0.</returns>
    public extern double MinWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that represents the actual calculated width of a ColumnDefinition.</summary>
    /// <returns>A Double that represents the actual calculated width in pixels. The default is 0.</returns>
    public extern double ActualWidth { [MethodImpl] get; }

    /// <summary>Identifies the Width dependency property.</summary>
    /// <returns>The identifier for the Width dependency property.</returns>
    public static extern DependencyProperty WidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxWidth dependency property.</summary>
    /// <returns>The identifier for the MaxWidth dependency property.</returns>
    public static extern DependencyProperty MaxWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinWidth dependency property.</summary>
    /// <returns>The identifier for the MinWidth dependency property.</returns>
    public static extern DependencyProperty MinWidthProperty { [MethodImpl] get; }
  }
}
