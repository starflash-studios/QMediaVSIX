// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IMediaProtectionPMPServer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaProtectionPMPServer))]
  [Guid(202445350, 31526, 19761, 149, 187, 156, 27, 8, 239, 127, 192)]
  internal interface IMediaProtectionPMPServer
  {
    IPropertySet Properties { get; }
  }
}
