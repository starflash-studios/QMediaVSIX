// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.IPerspectiveTransform3DStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  [WebHostHidden]
  [Guid(2389664768, 25100, 18631, 132, 77, 63, 9, 132, 218, 91, 23)]
  [ExclusiveTo(typeof (PerspectiveTransform3D))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerspectiveTransform3DStatics
  {
    DependencyProperty DepthProperty { get; }

    DependencyProperty OffsetXProperty { get; }

    DependencyProperty OffsetYProperty { get; }
  }
}
