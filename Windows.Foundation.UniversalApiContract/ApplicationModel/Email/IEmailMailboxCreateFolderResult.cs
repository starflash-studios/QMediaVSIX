// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxCreateFolderResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2988987775, 10373, 18840, 181, 149, 138, 45, 55, 76, 233, 80)]
  [ExclusiveTo(typeof (EmailMailboxCreateFolderResult))]
  internal interface IEmailMailboxCreateFolderResult
  {
    EmailMailboxCreateFolderStatus Status { get; }

    EmailFolder Folder { get; }
  }
}
