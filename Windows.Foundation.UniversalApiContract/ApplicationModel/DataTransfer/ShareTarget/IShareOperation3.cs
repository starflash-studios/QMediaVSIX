// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
  [ExclusiveTo(typeof (ShareOperation))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1593226114, 47015, 17777, 162, 166, 153, 74, 3, 73, 136, 178)]
  internal interface IShareOperation3
  {
    IVectorView<Contact> Contacts { get; }
  }
}
