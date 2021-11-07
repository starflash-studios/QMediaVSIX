// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRectangleGeometryStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (RectangleGeometry))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(931106234, 30978, 18659, 131, 190, 124, 128, 2, 166, 101, 60)]
  [WebHostHidden]
  internal interface IRectangleGeometryStatics
  {
    DependencyProperty RectProperty { get; }
  }
}
