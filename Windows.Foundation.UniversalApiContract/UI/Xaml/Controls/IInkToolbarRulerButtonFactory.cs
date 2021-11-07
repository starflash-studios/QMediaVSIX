// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarRulerButtonFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Deprecated("InkToolbarRulerButton is deprecated starting from Windows 10 Creators Update. Please use InkToolbarStencilButton going forward. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(3139885151, 53206, 18783, 147, 171, 184, 86, 106, 249, 248, 175)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InkToolbarRulerButton))]
  [WebHostHidden]
  internal interface IInkToolbarRulerButtonFactory
  {
    [Deprecated("InkToolbarRulerButton is deprecated starting from Windows 10 Creators Update. Please use InkToolbarStencilButton going forward. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    InkToolbarRulerButton CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
