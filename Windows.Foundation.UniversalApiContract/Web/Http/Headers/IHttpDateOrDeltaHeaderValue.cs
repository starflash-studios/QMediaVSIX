// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpDateOrDeltaHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpDateOrDeltaHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3942427242, 50396, 18914, 162, 125, 4, 58, 223, 88, 103, 163)]
  internal interface IHttpDateOrDeltaHeaderValue
  {
    IReference<DateTime> Date { get; }

    IReference<TimeSpan> Delta { get; }
  }
}
