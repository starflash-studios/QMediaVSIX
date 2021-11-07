// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppActivationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(1800571136, 62574, 20144, 170, 108, 56, 175, 85, 124, 249, 237)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (AppActivationResult))]
  internal interface IAppActivationResult
  {
    HResult ExtendedError { get; }

    AppResourceGroupInfo AppResourceGroupInfo { get; }
  }
}
