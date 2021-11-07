// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IRectangleStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Rectangle))]
  [Guid(2670045779, 47930, 19516, 137, 219, 111, 188, 13, 31, 160, 204)]
  internal interface IRectangleStatics
  {
    DependencyProperty RadiusXProperty { get; }

    DependencyProperty RadiusYProperty { get; }
  }
}
