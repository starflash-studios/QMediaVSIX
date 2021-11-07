// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(848831922, 36784, 16677, 187, 7, 231, 154, 90, 3, 129, 159)]
  [ExclusiveTo(typeof (ContentDialog))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IContentDialogStatics2
  {
    DependencyProperty CloseButtonTextProperty { get; }

    DependencyProperty CloseButtonCommandProperty { get; }

    DependencyProperty CloseButtonCommandParameterProperty { get; }

    DependencyProperty PrimaryButtonStyleProperty { get; }

    DependencyProperty SecondaryButtonStyleProperty { get; }

    DependencyProperty CloseButtonStyleProperty { get; }

    DependencyProperty DefaultButtonProperty { get; }
  }
}
