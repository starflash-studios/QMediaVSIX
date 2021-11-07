// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxMoveFolderRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Guid(945958944, 5306, 19592, 134, 152, 114, 57, 227, 200, 170, 167)]
  [ExclusiveTo(typeof (EmailMailboxMoveFolderRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxMoveFolderRequestEventArgs
  {
    EmailMailboxMoveFolderRequest Request { get; }

    Deferral GetDeferral();
  }
}
