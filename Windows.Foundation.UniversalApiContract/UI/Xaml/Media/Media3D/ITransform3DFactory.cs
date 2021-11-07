// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.ITransform3DFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Transform3D))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(86777722, 36211, 18637, 187, 184, 208, 4, 52, 202, 174, 93)]
  internal interface ITransform3DFactory
  {
    Transform3D CreateInstance(object baseInterface, out object innerInterface);
  }
}
