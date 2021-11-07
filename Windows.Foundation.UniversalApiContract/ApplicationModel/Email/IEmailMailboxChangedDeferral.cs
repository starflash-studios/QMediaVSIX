// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxChangedDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxChangedDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2006611137, 38853, 19284, 179, 13, 48, 98, 50, 98, 62, 109)]
  internal interface IEmailMailboxChangedDeferral
  {
    void Complete();
  }
}
