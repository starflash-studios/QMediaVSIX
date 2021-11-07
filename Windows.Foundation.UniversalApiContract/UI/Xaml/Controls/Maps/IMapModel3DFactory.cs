// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapModel3DFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(3749645260, 22538, 18827, 147, 155, 1, 25, 169, 218, 219, 158)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapModel3D))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMapModel3DFactory
  {
    MapModel3D CreateInstance(object baseInterface, out object innerInterface);
  }
}
