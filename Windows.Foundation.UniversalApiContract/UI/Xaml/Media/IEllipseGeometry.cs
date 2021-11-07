// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IEllipseGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(3572898746, 20130, 16598, 170, 108, 141, 56, 170, 135, 101, 31)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EllipseGeometry))]
  [WebHostHidden]
  internal interface IEllipseGeometry
  {
    Point Center { get; set; }

    double RadiusX { get; set; }

    double RadiusY { get; set; }
  }
}
