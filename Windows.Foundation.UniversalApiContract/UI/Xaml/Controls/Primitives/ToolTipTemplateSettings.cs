// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ToolTipTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a ToolTip control. Not intended for general use.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ToolTipTemplateSettings : DependencyObject, IToolTipTemplateSettings
  {
    /// <summary>Gets the offset that is appropriate as a value for **FromHorizontalOffset** in theme animations.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double FromHorizontalOffset { [MethodImpl] get; }

    /// <summary>Gets the offset that is appropriate as a value for **FromVerticalOffset** in theme animations.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double FromVerticalOffset { [MethodImpl] get; }
  }
}
