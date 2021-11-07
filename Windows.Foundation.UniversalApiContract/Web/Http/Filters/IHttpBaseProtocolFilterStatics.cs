// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpBaseProtocolFilterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Web.Http.Filters
{
  [Guid(1833823756, 59656, 18766, 181, 163, 18, 99, 201, 184, 36, 42)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (HttpBaseProtocolFilter))]
  internal interface IHttpBaseProtocolFilterStatics
  {
    HttpBaseProtocolFilter CreateForUser(User user);
  }
}
