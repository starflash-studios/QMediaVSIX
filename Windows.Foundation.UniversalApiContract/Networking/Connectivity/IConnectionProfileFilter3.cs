// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfileFilter3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (ConnectionProfileFilter))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(178915776, 20500, 17532, 136, 9, 174, 228, 203, 10, 249, 74)]
  internal interface IConnectionProfileFilter3
  {
    IReference<Guid> PurposeGuid { set; get; }
  }
}
