// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IMatrixTransformStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(1138765383, 5560, 18264, 187, 151, 125, 82, 66, 10, 204, 91)]
  [ExclusiveTo(typeof (MatrixTransform))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IMatrixTransformStatics
  {
    DependencyProperty MatrixProperty { get; }
  }
}
