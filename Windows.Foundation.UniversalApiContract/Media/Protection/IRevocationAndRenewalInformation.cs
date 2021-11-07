// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IRevocationAndRenewalInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ExclusiveTo(typeof (RevocationAndRenewalInformation))]
  [Guid(4087452539, 9473, 17310, 166, 231, 111, 201, 94, 23, 95, 207)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRevocationAndRenewalInformation
  {
    IVector<RevocationAndRenewalItem> Items { get; }
  }
}
