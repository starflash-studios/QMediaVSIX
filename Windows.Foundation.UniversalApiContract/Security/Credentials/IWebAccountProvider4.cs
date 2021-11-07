// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccountProvider4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [Guid(1905252571, 59286, 16912, 183, 78, 132, 210, 152, 148, 176, 128)]
  [ExclusiveTo(typeof (WebAccountProvider))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IWebAccountProvider4
  {
    bool IsSystemProvider { get; }
  }
}
