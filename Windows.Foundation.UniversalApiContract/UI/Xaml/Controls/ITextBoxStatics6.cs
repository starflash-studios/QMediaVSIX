// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxStatics6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3691878375, 7351, 17214, 170, 79, 156, 100, 201, 140, 222, 229)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TextBox))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ITextBoxStatics6
  {
    DependencyProperty HorizontalTextAlignmentProperty { get; }

    DependencyProperty CharacterCasingProperty { get; }

    DependencyProperty PlaceholderForegroundProperty { get; }
  }
}
