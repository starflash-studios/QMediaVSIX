// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccountProvider2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ExclusiveTo(typeof (WebAccountProvider))]
  [Guid(1241639685, 20034, 16852, 181, 24, 224, 8, 165, 22, 54, 20)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAccountProvider2 : IWebAccountProvider
  {
    string DisplayPurpose { get; }

    string Authority { get; }
  }
}
