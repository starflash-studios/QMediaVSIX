// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IRectangle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Rectangle))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2237383216, 35345, 19992, 161, 54, 75, 194, 28, 120, 39, 176)]
  internal interface IRectangle
  {
    double RadiusX { get; set; }

    double RadiusY { get; set; }
  }
}
