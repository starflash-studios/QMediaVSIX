// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactStore3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactStore))]
  [Guid(3414699116, 78, 16464, 135, 240, 132, 4, 7, 238, 104, 24)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IContactStore3
  {
    ContactChangeTracker GetChangeTracker(string identity);
  }
}
