// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.Provider.IContactRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.Provider
{
  [ExclusiveTo(typeof (ContactRemovedEventArgs))]
  [Guid(1865761592, 13058, 19731, 173, 141, 173, 204, 15, 249, 228, 124)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactRemovedEventArgs
  {
    string Id { get; }
  }
}
