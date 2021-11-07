// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(598427558, 20618, 20275, 183, 134, 242, 250, 150, 216, 105, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentDialog))]
  [WebHostHidden]
  internal interface IContentDialogStatics
  {
    DependencyProperty TitleProperty { get; }

    DependencyProperty TitleTemplateProperty { get; }

    DependencyProperty FullSizeDesiredProperty { get; }

    DependencyProperty PrimaryButtonTextProperty { get; }

    DependencyProperty SecondaryButtonTextProperty { get; }

    DependencyProperty PrimaryButtonCommandProperty { get; }

    DependencyProperty SecondaryButtonCommandProperty { get; }

    DependencyProperty PrimaryButtonCommandParameterProperty { get; }

    DependencyProperty SecondaryButtonCommandParameterProperty { get; }

    DependencyProperty IsPrimaryButtonEnabledProperty { get; }

    DependencyProperty IsSecondaryButtonEnabledProperty { get; }
  }
}
