// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IRevocationAndRenewalItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [Guid(815383052, 15600, 18922, 144, 45, 202, 243, 45, 45, 222, 44)]
  [ExclusiveTo(typeof (RevocationAndRenewalItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRevocationAndRenewalItem
  {
    RevocationAndRenewalReasons Reasons { get; }

    string HeaderHash { get; }

    string PublicKeyHash { get; }

    string Name { get; }

    string RenewalId { get; }
  }
}
