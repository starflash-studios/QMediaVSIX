// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILineGeometryStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LineGeometry))]
  [Guid(1468720995, 21858, 20196, 135, 3, 234, 64, 54, 216, 145, 227)]
  internal interface ILineGeometryStatics
  {
    DependencyProperty StartPointProperty { get; }

    DependencyProperty EndPointProperty { get; }
  }
}
