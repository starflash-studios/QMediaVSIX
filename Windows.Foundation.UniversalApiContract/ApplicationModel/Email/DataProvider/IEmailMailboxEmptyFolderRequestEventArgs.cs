// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxEmptyFolderRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1904473220, 39002, 19136, 179, 63, 238, 14, 38, 39, 163, 192)]
  [ExclusiveTo(typeof (EmailMailboxEmptyFolderRequestEventArgs))]
  internal interface IEmailMailboxEmptyFolderRequestEventArgs
  {
    EmailMailboxEmptyFolderRequest Request { get; }

    Deferral GetDeferral();
  }
}
