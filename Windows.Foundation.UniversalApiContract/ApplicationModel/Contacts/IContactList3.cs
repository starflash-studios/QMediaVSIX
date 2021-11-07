// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactList3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactList))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(360246871, 9980, 16872, 168, 80, 90, 163, 37, 20, 172, 169)]
  internal interface IContactList3
  {
    ContactListLimitedWriteOperations LimitedWriteOperations { get; }

    ContactChangeTracker GetChangeTracker(string identity);
  }
}
