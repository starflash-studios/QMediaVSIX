// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControl8
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(10394694, 29261, 21450, 148, 33, 122, 72, 252, 115, 21, 35)]
  [ExclusiveTo(typeof (MapControl))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IMapControl8
  {
    bool CanTiltDown { get; }

    bool CanTiltUp { get; }

    bool CanZoomIn { get; }

    bool CanZoomOut { get; }
  }
}
