// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentCodingWithQualityHeaderValueCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(2081256766, 59545, 17272, 181, 200, 65, 45, 130, 7, 17, 204)]
  [ExclusiveTo(typeof (HttpContentCodingWithQualityHeaderValueCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpContentCodingWithQualityHeaderValueCollection
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
