// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapElementStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(3776899375, 38722, 18858, 170, 216, 46, 70, 107, 255, 55, 150)]
  [ExclusiveTo(typeof (MapElement))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IMapElementStatics3
  {
    DependencyProperty MapStyleSheetEntryProperty { get; }

    DependencyProperty MapStyleSheetEntryStateProperty { get; }

    DependencyProperty TagProperty { get; }
  }
}
