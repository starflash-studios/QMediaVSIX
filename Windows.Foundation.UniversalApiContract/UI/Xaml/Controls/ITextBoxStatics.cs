// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextBox))]
  [Guid(2117596411, 42172, 17957, 136, 56, 142, 178, 169, 9, 18, 131)]
  internal interface ITextBoxStatics
  {
    DependencyProperty TextProperty { get; }

    DependencyProperty MaxLengthProperty { get; }

    DependencyProperty IsReadOnlyProperty { get; }

    DependencyProperty AcceptsReturnProperty { get; }

    DependencyProperty TextAlignmentProperty { get; }

    DependencyProperty TextWrappingProperty { get; }

    DependencyProperty IsSpellCheckEnabledProperty { get; }

    DependencyProperty IsTextPredictionEnabledProperty { get; }

    DependencyProperty InputScopeProperty { get; }
  }
}
