// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpBaseProtocolFilter5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Web.Http.Filters
{
  [ExclusiveTo(typeof (HttpBaseProtocolFilter))]
  [Guid(1097746835, 12771, 18454, 191, 9, 224, 24, 238, 141, 193, 245)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IHttpBaseProtocolFilter5
  {
    User User { get; }
  }
}
