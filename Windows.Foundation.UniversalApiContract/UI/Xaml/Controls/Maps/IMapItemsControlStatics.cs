// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapItemsControlStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(866671047, 30875, 16988, 138, 10, 50, 56, 88, 150, 203, 74)]
  [ExclusiveTo(typeof (MapItemsControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IMapItemsControlStatics
  {
    DependencyProperty ItemsSourceProperty { get; }

    DependencyProperty ItemsProperty { get; }

    DependencyProperty ItemTemplateProperty { get; }
  }
}
