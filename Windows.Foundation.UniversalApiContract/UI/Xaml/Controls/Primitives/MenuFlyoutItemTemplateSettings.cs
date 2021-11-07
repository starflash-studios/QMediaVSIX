// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.MenuFlyoutItemTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a MenuFlyoutItem control. Not intended for general use.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class MenuFlyoutItemTemplateSettings : 
    DependencyObject,
    IMenuFlyoutItemTemplateSettings
  {
    /// <summary>Gets the minimum width allocated for the accelerator key tip of an MenuFlyout.</summary>
    /// <returns>A number that specifies the minimum width allocated for the accelerator key tip of an MenuFlyout.</returns>
    public extern double KeyboardAcceleratorTextMinWidth { [MethodImpl] get; }
  }
}
