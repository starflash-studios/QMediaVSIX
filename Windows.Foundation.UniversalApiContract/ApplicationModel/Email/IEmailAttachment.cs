// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailAttachment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailAttachment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4082354937, 22472, 19163, 185, 146, 96, 252, 235, 88, 79, 84)]
  internal interface IEmailAttachment
  {
    string FileName { get; set; }

    IRandomAccessStreamReference Data { get; set; }
  }
}
