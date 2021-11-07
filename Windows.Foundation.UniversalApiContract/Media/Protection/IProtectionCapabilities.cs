// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IProtectionCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [Guid(3349962110, 29824, 19753, 164, 100, 123, 205, 145, 61, 216, 228)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (ProtectionCapabilities))]
  internal interface IProtectionCapabilities
  {
    ProtectionCapabilityResult IsTypeSupported(
      string type,
      string keySystem);
  }
}
