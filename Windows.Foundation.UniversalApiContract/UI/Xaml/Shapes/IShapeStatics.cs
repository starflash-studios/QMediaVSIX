// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IShapeStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [ExclusiveTo(typeof (Shape))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(494619733, 40435, 18652, 145, 148, 157, 48, 111, 170, 96, 137)]
  internal interface IShapeStatics
  {
    DependencyProperty FillProperty { get; }

    DependencyProperty StrokeProperty { get; }

    DependencyProperty StrokeMiterLimitProperty { get; }

    DependencyProperty StrokeThicknessProperty { get; }

    DependencyProperty StrokeStartLineCapProperty { get; }

    DependencyProperty StrokeEndLineCapProperty { get; }

    DependencyProperty StrokeLineJoinProperty { get; }

    DependencyProperty StrokeDashOffsetProperty { get; }

    DependencyProperty StrokeDashCapProperty { get; }

    DependencyProperty StrokeDashArrayProperty { get; }

    DependencyProperty StretchProperty { get; }
  }
}
