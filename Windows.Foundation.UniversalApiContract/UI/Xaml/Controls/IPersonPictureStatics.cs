// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPersonPictureStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3689679234, 15376, 17977, 150, 20, 170, 91, 124, 220, 50, 202)]
  [ExclusiveTo(typeof (PersonPicture))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IPersonPictureStatics
  {
    DependencyProperty BadgeNumberProperty { get; }

    DependencyProperty BadgeGlyphProperty { get; }

    DependencyProperty BadgeImageSourceProperty { get; }

    DependencyProperty BadgeTextProperty { get; }

    DependencyProperty IsGroupProperty { get; }

    DependencyProperty ContactProperty { get; }

    DependencyProperty DisplayNameProperty { get; }

    DependencyProperty InitialsProperty { get; }

    DependencyProperty PreferSmallImageProperty { get; }

    DependencyProperty ProfilePictureProperty { get; }
  }
}
