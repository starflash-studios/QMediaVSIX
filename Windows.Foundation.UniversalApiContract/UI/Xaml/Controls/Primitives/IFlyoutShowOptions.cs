// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutShowOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(1473680301, 3188, 21725, 177, 16, 30, 228, 63, 171, 173, 217)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (FlyoutShowOptions))]
  internal interface IFlyoutShowOptions
  {
    IReference<Point> Position { get; set; }

    IReference<Rect> ExclusionRect { get; set; }

    FlyoutShowMode ShowMode { get; set; }

    FlyoutPlacementMode Placement { get; set; }
  }
}
