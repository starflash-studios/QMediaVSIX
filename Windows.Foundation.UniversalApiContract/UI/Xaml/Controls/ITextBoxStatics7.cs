// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxStatics7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBox))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3446435655, 5246, 18168, 164, 232, 116, 156, 73, 132, 122, 62)]
  internal interface ITextBoxStatics7
  {
    DependencyProperty HandwritingViewProperty { get; }

    DependencyProperty IsHandwritingViewEnabledProperty { get; }
  }
}
