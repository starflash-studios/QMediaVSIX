// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailbox5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(966160519, 146, 18878, 189, 14, 93, 77, 201, 217, 109, 144)]
  [ExclusiveTo(typeof (EmailMailbox))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IEmailMailbox5
  {
    EmailMailboxChangeTracker GetChangeTracker(string identity);
  }
}
