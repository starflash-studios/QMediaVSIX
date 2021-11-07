// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarRulerButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Deprecated("InkToolbarRulerButton is deprecated starting from Windows 10 Creators Update. Please use InkToolbarStencilButton going forward. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InkToolbarRulerButton))]
  [Guid(1251551282, 6532, 16712, 159, 37, 56, 43, 53, 219, 8, 127)]
  internal interface IInkToolbarRulerButton
  {
    InkPresenterRuler Ruler { [Deprecated("InkToolbarRulerButton is deprecated starting from Windows 10 Creators Update. Please use InkToolbarStencilButton going forward. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
