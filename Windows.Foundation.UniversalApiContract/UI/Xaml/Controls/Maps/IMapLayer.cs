// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapLayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(1829763521, 41293, 20375, 143, 87, 70, 113, 91, 87, 104, 58)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapLayer))]
  internal interface IMapLayer
  {
    int MapTabIndex { get; set; }

    bool Visible { get; set; }

    int ZIndex { get; set; }
  }
}
