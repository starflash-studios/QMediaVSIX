// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactChangedEventArgs))]
  [Guid(1381924817, 29683, 19325, 169, 24, 88, 11, 228, 54, 97, 33)]
  internal interface IContactChangedEventArgs
  {
    ContactChangedDeferral GetDeferral();
  }
}
