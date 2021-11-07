// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IPinnedContactIdsQueryResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (PinnedContactIdsQueryResult))]
  [Guid(2107319634, 5497, 19932, 135, 31, 163, 10, 58, 234, 155, 161)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPinnedContactIdsQueryResult
  {
    IVector<string> ContactIds { get; }
  }
}
