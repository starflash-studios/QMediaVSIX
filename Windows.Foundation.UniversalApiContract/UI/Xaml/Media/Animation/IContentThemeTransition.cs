// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IContentThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ContentThemeTransition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4134520259, 22805, 17277, 142, 59, 173, 248, 231, 240, 171, 87)]
  [WebHostHidden]
  internal interface IContentThemeTransition
  {
    double HorizontalOffset { get; set; }

    double VerticalOffset { get; set; }
  }
}
