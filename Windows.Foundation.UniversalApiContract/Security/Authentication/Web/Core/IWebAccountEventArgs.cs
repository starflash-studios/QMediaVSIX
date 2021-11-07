// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebAccountEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [ExclusiveTo(typeof (WebAccountEventArgs))]
  [Guid(1874264957, 16974, 17644, 151, 124, 239, 36, 21, 70, 42, 90)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IWebAccountEventArgs
  {
    WebAccount Account { get; }
  }
}
