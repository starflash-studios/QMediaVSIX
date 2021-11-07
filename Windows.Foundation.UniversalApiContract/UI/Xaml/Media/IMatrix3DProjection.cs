// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IMatrix3DProjection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Media3D;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Matrix3DProjection))]
  [Guid(1862525257, 49097, 19457, 181, 120, 80, 51, 140, 236, 151, 252)]
  internal interface IMatrix3DProjection
  {
    Matrix3D ProjectionMatrix { get; set; }
  }
}
