// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailRecipient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailRecipient))]
  [Guid(3404211635, 17528, 18452, 185, 0, 201, 2, 181, 225, 155, 83)]
  internal interface IEmailRecipient
  {
    string Name { get; set; }

    string Address { get; set; }
  }
}
