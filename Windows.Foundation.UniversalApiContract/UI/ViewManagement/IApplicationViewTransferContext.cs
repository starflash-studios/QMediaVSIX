// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewTransferContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ApplicationViewTransferContext))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2239020131, 15383, 16526, 148, 8, 138, 26, 158, 168, 27, 250)]
  internal interface IApplicationViewTransferContext
  {
    int ViewId { get; set; }
  }
}
