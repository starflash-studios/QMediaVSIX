// Decompiled with JetBrains decompiler
// Type: Windows.Web.IWebErrorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4267796326, 48935, 16484, 135, 183, 101, 99, 187, 17, 206, 46)]
  [ExclusiveTo(typeof (WebError))]
  internal interface IWebErrorStatics
  {
    WebErrorStatus GetStatus(int hresult);
  }
}
