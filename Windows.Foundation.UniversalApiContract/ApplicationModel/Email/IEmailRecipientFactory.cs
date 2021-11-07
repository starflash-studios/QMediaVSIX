// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailRecipientFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(1426110541, 51098, 20216, 185, 9, 114, 46, 24, 227, 147, 93)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailRecipient))]
  internal interface IEmailRecipientFactory
  {
    EmailRecipient Create(string address);

    EmailRecipient CreateWithName(string address, string name);
  }
}
