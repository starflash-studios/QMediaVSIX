// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.SplitViewTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a SplitView. Not intended for general use.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SplitViewTemplateSettings : DependencyObject, ISplitViewTemplateSettings
  {
    /// <summary>Gets the OpenPaneLength value.</summary>
    /// <returns>The OpenPaneLength value.</returns>
    public extern double OpenPaneLength { [MethodImpl] get; }

    /// <summary>Gets the negative of the OpenPaneLength value.</summary>
    /// <returns>The negative of the OpenPaneLength value.</returns>
    public extern double NegativeOpenPaneLength { [MethodImpl] get; }

    /// <summary>Gets a value calculated by subtracting the CompactPaneLength value from the OpenPaneLength value.</summary>
    /// <returns>The value calculated by subtracting the CompactPaneLength value from the OpenPaneLength value.</returns>
    public extern double OpenPaneLengthMinusCompactLength { [MethodImpl] get; }

    /// <summary>Gets the negative of the value calculated by subtracting the CompactPaneLength value from the OpenPaneLength value.</summary>
    /// <returns>The negative of the OpenPaneLength value minus the CompactPaneLength value.</returns>
    public extern double NegativeOpenPaneLengthMinusCompactLength { [MethodImpl] get; }

    /// <summary>Gets the OpenPaneLength value as a GridLength.</summary>
    /// <returns>The OpenPaneLength value as a GridLength.</returns>
    public extern GridLength OpenPaneGridLength { [MethodImpl] get; }

    /// <summary>Gets the CompactPaneLength value as a GridLength.</summary>
    /// <returns>The CompactPaneLength value as a GridLength.</returns>
    public extern GridLength CompactPaneGridLength { [MethodImpl] get; }
  }
}
