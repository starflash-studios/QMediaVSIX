// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragOperationDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3128159418, 7027, 16518, 179, 211, 194, 35, 190, 234, 22, 51)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DragOperationDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDragOperationDeferral
  {
    void Complete();
  }
}
