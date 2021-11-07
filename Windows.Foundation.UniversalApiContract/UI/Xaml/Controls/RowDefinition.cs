// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RowDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines row-specific properties that apply to Grid elements.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IRowDefinitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class RowDefinition : DependencyObject, IRowDefinition
  {
    /// <summary>Initializes a new instance of the RowDefinition class.</summary>
    [MethodImpl]
    public extern RowDefinition();

    /// <summary>Gets the calculated height of a RowDefinition element, or sets the GridLength value of a row that is defined by the RowDefinition.</summary>
    /// <returns>The GridLength that represents the height of the row. The default value is a GridLength representing a "1\*" sizing.</returns>
    public extern GridLength Height { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that represents the maximum height of a RowDefinition.</summary>
    /// <returns>A Double that represents the maximum height.</returns>
    public extern double MaxHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that represents the minimum allowed height of a RowDefinition.</summary>
    /// <returns>A Double that represents the minimum allowed height. The default value is 0.</returns>
    public extern double MinHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that represents the calculated height of the RowDefinition.</summary>
    /// <returns>A value that represents the calculated height in pixels. The default value is 0.</returns>
    public extern double ActualHeight { [MethodImpl] get; }

    /// <summary>Identifies the Height dependency property.</summary>
    /// <returns>The identifier for the Height dependency property.</returns>
    public static extern DependencyProperty HeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxHeight dependency property.</summary>
    /// <returns>The identifier for the MaxHeight dependency property.</returns>
    public static extern DependencyProperty MaxHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinHeight dependency property.</summary>
    /// <returns>The identifier for the MinHeight dependency property.</returns>
    public static extern DependencyProperty MinHeightProperty { [MethodImpl] get; }
  }
}
