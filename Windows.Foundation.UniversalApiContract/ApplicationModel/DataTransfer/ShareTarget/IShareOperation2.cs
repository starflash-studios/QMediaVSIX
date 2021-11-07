// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ShareOperation))]
  [Guid(268146625, 38776, 18953, 142, 91, 203, 94, 72, 45, 5, 85)]
  internal interface IShareOperation2
  {
    void DismissUI();
  }
}
