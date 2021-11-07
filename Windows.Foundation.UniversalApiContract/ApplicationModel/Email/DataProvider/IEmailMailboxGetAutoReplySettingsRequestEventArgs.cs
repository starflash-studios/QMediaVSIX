// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxGetAutoReplySettingsRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Guid(3617543618, 64837, 16388, 138, 145, 155, 172, 243, 139, 112, 34)]
  [ExclusiveTo(typeof (EmailMailboxGetAutoReplySettingsRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxGetAutoReplySettingsRequestEventArgs
  {
    EmailMailboxGetAutoReplySettingsRequest Request { get; }

    Deferral GetDeferral();
  }
}
