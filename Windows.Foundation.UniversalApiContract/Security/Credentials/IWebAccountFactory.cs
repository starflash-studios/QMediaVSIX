// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccountFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2895838009, 7657, 20114, 183, 143, 5, 129, 168, 127, 110, 92)]
  [ExclusiveTo(typeof (WebAccount))]
  internal interface IWebAccountFactory
  {
    WebAccount CreateWebAccount(
      WebAccountProvider webAccountProvider,
      string userName,
      WebAccountState state);
  }
}
