// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactLaunchActionVerbsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(4212273878, 61043, 18151, 135, 97, 17, 205, 1, 87, 114, 143)]
  [ExclusiveTo(typeof (ContactLaunchActionVerbs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactLaunchActionVerbsStatics
  {
    string Call { get; }

    string Message { get; }

    string Map { get; }

    string Post { get; }

    string VideoCall { get; }
  }
}
