// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactChangedDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactChangedDeferral))]
  [Guid(3306437352, 6915, 18168, 182, 148, 165, 35, 232, 60, 252, 182)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactChangedDeferral
  {
    void Complete();
  }
}
