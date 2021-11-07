// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactConnectedServiceAccount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(4143461715, 43559, 18225, 142, 74, 61, 236, 92, 233, 238, 201)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactConnectedServiceAccount))]
  internal interface IContactConnectedServiceAccount
  {
    string Id { get; set; }

    string ServiceName { get; set; }
  }
}
