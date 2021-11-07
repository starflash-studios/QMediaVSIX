// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarRulerButtonStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(3135725413, 48688, 19438, 150, 75, 255, 158, 73, 143, 238, 55)]
  [ExclusiveTo(typeof (InkToolbarRulerButton))]
  [Deprecated("InkToolbarRulerButton is deprecated starting from Windows 10 Creators Update. Please use InkToolbarStencilButton going forward. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IInkToolbarRulerButtonStatics
  {
    DependencyProperty RulerProperty { [Deprecated("InkToolbarRulerButton is deprecated starting from Windows 10 Creators Update. Please use InkToolbarStencilButton going forward. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
