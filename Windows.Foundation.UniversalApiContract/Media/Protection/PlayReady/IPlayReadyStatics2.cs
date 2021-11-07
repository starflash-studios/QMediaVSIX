// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyStatics))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(529361554, 24474, 16958, 148, 102, 179, 57, 105, 175, 122, 61)]
  internal interface IPlayReadyStatics2 : IPlayReadyStatics
  {
    uint PlayReadyCertificateSecurityLevel { get; }
  }
}
