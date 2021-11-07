// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactCardOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(2349485950, 27318, 20287, 190, 114, 129, 114, 54, 238, 234, 91)]
  [ExclusiveTo(typeof (ContactCardOptions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactCardOptions
  {
    ContactCardHeaderKind HeaderKind { get; set; }

    ContactCardTabKind InitialTabKind { get; set; }
  }
}
