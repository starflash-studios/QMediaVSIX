// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccountProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ExclusiveTo(typeof (WebAccountProvider))]
  [Guid(702335171, 31417, 19068, 163, 54, 185, 66, 249, 219, 247, 199)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAccountProvider
  {
    string Id { get; }

    string DisplayName { get; }

    Uri IconUri { [Deprecated("IconUri may be altered or unavailable for releases after Windows 8.2. Instead, use Icon.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
