﻿// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentCodingWithQualityHeaderValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3905500540, 36745, 18433, 142, 117, 76, 154, 191, 195, 222, 113)]
  [ExclusiveTo(typeof (HttpContentCodingWithQualityHeaderValue))]
  internal interface IHttpContentCodingWithQualityHeaderValueStatics
  {
    HttpContentCodingWithQualityHeaderValue Parse(
      string input);

    bool TryParse(
      string input,
      out HttpContentCodingWithQualityHeaderValue contentCodingWithQualityHeaderValue);
  }
}