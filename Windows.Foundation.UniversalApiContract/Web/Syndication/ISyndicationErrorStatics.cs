// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationErrorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(532357985, 17863, 18483, 138, 160, 190, 95, 59, 88, 167, 244)]
  [ExclusiveTo(typeof (SyndicationError))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationErrorStatics
  {
    SyndicationErrorStatus GetStatus(int hresult);
  }
}
