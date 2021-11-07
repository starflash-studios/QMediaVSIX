// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITileBrushStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (TileBrush))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(882360923, 46434, 20072, 132, 53, 35, 153, 246, 235, 148, 213)]
  internal interface ITileBrushStatics
  {
    DependencyProperty AlignmentXProperty { get; }

    DependencyProperty AlignmentYProperty { get; }

    DependencyProperty StretchProperty { get; }
  }
}
