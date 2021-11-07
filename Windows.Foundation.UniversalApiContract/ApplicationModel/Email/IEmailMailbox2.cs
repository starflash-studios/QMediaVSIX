// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailbox2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(351855620, 27810, 19122, 146, 65, 121, 205, 123, 244, 99, 70)]
  [ExclusiveTo(typeof (EmailMailbox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMailbox2 : IEmailMailbox
  {
    string LinkedMailboxId { get; }

    string NetworkAccountId { get; }

    string NetworkId { get; }
  }
}
