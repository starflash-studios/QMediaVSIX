// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileSourceStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapTileSource))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1976423550, 26268, 20733, 173, 133, 94, 165, 23, 76, 245, 155)]
  internal interface IMapTileSourceStatics2
  {
    DependencyProperty AnimationStateProperty { get; }

    DependencyProperty AutoPlayProperty { get; }

    DependencyProperty FrameCountProperty { get; }

    DependencyProperty FrameDurationProperty { get; }
  }
}
