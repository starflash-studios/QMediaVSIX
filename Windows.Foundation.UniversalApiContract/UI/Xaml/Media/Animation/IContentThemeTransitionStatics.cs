// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IContentThemeTransitionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ContentThemeTransition))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(244245381, 39490, 17497, 175, 169, 51, 125, 196, 30, 21, 135)]
  internal interface IContentThemeTransitionStatics
  {
    DependencyProperty HorizontalOffsetProperty { get; }

    DependencyProperty VerticalOffsetProperty { get; }
  }
}
