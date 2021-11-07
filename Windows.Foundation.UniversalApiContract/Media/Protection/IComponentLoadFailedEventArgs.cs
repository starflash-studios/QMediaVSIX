// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IComponentLoadFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2509713043, 30534, 16766, 132, 149, 240, 49, 187, 197, 134, 44)]
  [ExclusiveTo(typeof (ComponentLoadFailedEventArgs))]
  internal interface IComponentLoadFailedEventArgs
  {
    RevocationAndRenewalInformation Information { get; }

    MediaProtectionServiceCompletion Completion { get; }
  }
}
