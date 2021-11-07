// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileBitmapRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(863987997, 39682, 19106, 139, 30, 204, 77, 145, 113, 155, 243)]
  [ExclusiveTo(typeof (MapTileBitmapRequestedEventArgs))]
  internal interface IMapTileBitmapRequestedEventArgs
  {
    int X { get; }

    int Y { get; }

    int ZoomLevel { get; }

    MapTileBitmapRequest Request { get; }
  }
}
