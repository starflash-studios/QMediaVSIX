// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebProviderErrorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebProviderError))]
  [Guid(3821275693, 35311, 20023, 132, 127, 168, 185, 213, 163, 41, 16)]
  internal interface IWebProviderErrorFactory
  {
    WebProviderError Create(uint errorCode, string errorMessage);
  }
}
