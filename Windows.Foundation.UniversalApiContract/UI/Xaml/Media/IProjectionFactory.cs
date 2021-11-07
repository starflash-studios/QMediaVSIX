// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IProjectionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (Projection))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3304234155, 24749, 20260, 189, 39, 157, 105, 195, 18, 124, 154)]
  internal interface IProjectionFactory
  {
    Projection CreateInstance(object baseInterface, out object innerInterface);
  }
}
