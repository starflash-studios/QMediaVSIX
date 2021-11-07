// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ILoopingSelectorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(65583866, 35965, 20421, 185, 42, 240, 73, 251, 147, 60, 197)]
  [WebHostHidden]
  [ExclusiveTo(typeof (LoopingSelector))]
  internal interface ILoopingSelectorStatics
  {
    DependencyProperty ShouldLoopProperty { get; }

    DependencyProperty ItemsProperty { get; }

    DependencyProperty SelectedIndexProperty { get; }

    DependencyProperty SelectedItemProperty { get; }

    DependencyProperty ItemWidthProperty { get; }

    DependencyProperty ItemHeightProperty { get; }

    DependencyProperty ItemTemplateProperty { get; }
  }
}
