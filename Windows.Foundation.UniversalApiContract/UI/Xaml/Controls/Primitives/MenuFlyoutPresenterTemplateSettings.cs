// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.MenuFlyoutPresenterTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a MenuFlyoutPresenter control. Not intended for general use.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MenuFlyoutPresenterTemplateSettings : 
    DependencyObject,
    IMenuFlyoutPresenterTemplateSettings
  {
    /// <summary>Gets the minimum width of flyout content.</summary>
    /// <returns>The minimum width of flyout content.</returns>
    public extern double FlyoutContentMinWidth { [MethodImpl] get; }
  }
}
