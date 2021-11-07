// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPathFigureStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (PathFigure))]
  [Guid(3053818329, 9109, 17175, 149, 82, 58, 88, 82, 111, 140, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IPathFigureStatics
  {
    DependencyProperty SegmentsProperty { get; }

    DependencyProperty StartPointProperty { get; }

    DependencyProperty IsClosedProperty { get; }

    DependencyProperty IsFilledProperty { get; }
  }
}
