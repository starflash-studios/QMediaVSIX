// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailIrmTemplate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(4079449485, 21613, 19434, 169, 99, 84, 163, 139, 44, 192, 22)]
  [ExclusiveTo(typeof (EmailIrmTemplate))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailIrmTemplate
  {
    string Id { get; set; }

    string Description { get; set; }

    string Name { get; set; }
  }
}
