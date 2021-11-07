// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewTransferContextStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(363371922, 56697, 19211, 188, 71, 213, 241, 149, 241, 70, 97)]
  [ExclusiveTo(typeof (ApplicationViewTransferContext))]
  internal interface IApplicationViewTransferContextStatics
  {
    string DataPackageFormatId { get; }
  }
}
