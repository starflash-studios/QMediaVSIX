// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxCreateFolderRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxCreateFolderRequestEventArgs))]
  [Guid(65323052, 9244, 20137, 166, 143, 255, 32, 188, 90, 252, 133)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxCreateFolderRequestEventArgs
  {
    EmailMailboxCreateFolderRequest Request { get; }

    Deferral GetDeferral();
  }
}
