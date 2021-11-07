// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMessage3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (EmailMessage))]
  [Guid(2716493660, 58776, 19753, 160, 24, 252, 123, 126, 236, 224, 161)]
  internal interface IEmailMessage3
  {
    IRandomAccessStreamReference SmimeData { get; set; }

    EmailMessageSmimeKind SmimeKind { get; set; }
  }
}
