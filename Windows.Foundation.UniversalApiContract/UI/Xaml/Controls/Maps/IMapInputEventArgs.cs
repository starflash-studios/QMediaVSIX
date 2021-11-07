// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapInputEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2680488864, 43170, 17300, 146, 233, 34, 71, 118, 79, 47, 73)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapInputEventArgs))]
  internal interface IMapInputEventArgs
  {
    Point Position { get; }

    Geopoint Location { get; }
  }
}
