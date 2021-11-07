// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlStatics8
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Guid(2914494384, 1541, 22828, 191, 157, 209, 11, 220, 43, 228, 123)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (MapControl))]
  internal interface IMapControlStatics8
  {
    DependencyProperty CanTiltDownProperty { get; }

    DependencyProperty CanTiltUpProperty { get; }

    DependencyProperty CanZoomInProperty { get; }

    DependencyProperty CanZoomOutProperty { get; }
  }
}
