// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxAutoReply
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxAutoReply))]
  [Guid(3793954124, 35508, 18523, 179, 31, 4, 209, 84, 118, 189, 89)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMailboxAutoReply
  {
    bool IsEnabled { get; set; }

    string Response { get; set; }
  }
}
