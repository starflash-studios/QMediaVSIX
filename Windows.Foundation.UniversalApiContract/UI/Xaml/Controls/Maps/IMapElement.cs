// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapElement))]
  [Guid(3592406239, 45637, 18418, 154, 194, 67, 192, 88, 177, 201, 3)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapElement
  {
    int ZIndex { get; set; }

    bool Visible { get; set; }
  }
}
