// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IMediaProtectionPMPServerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [Guid(1613532766, 63442, 18558, 175, 145, 219, 196, 37, 43, 33, 130)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaProtectionPMPServer))]
  internal interface IMediaProtectionPMPServerFactory
  {
    MediaProtectionPMPServer CreatePMPServer(IPropertySet pProperties);
  }
}
