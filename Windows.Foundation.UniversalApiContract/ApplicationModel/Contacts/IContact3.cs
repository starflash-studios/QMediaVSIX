// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContact3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(1210064487, 57486, 17060, 181, 97, 65, 208, 140, 169, 87, 93)]
  [ExclusiveTo(typeof (Contact))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContact3 : IContact2, IContact
  {
    string ContactListId { get; }

    DateTime DisplayPictureUserUpdateTime { get; set; }

    bool IsMe { get; }

    string AggregateId { get; }

    string RemoteId { get; set; }

    string RingToneToken { get; set; }

    bool IsDisplayPictureManuallySet { get; }

    IRandomAccessStreamReference LargeDisplayPicture { get; }

    IRandomAccessStreamReference SmallDisplayPicture { get; }

    IRandomAccessStreamReference SourceDisplayPicture { get; set; }

    string TextToneToken { get; set; }

    bool IsAggregate { get; }

    string FullName { get; }

    string DisplayNameOverride { get; set; }

    string Nickname { get; set; }

    string SortName { get; }
  }
}
