// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapActualCameraChangedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapActualCameraChangedEventArgs))]
  [Guid(2074396645, 4316, 17754, 157, 4, 29, 114, 251, 109, 155, 147)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IMapActualCameraChangedEventArgs2
  {
    MapCameraChangeReason ChangeReason { get; }
  }
}
