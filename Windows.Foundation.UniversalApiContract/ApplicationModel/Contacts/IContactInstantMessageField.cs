// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactInstantMessageField
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactInstantMessageField))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3437443895, 3461, 16890, 180, 61, 218, 89, 156, 62, 176, 9)]
  internal interface IContactInstantMessageField : IContactField
  {
    string UserName { get; }

    string Service { get; }

    string DisplayText { get; }

    Uri LaunchUri { get; }
  }
}
