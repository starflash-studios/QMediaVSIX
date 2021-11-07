// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IESimServiceInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (ESimServiceInfo))]
  [Guid(4050299855, 32601, 19025, 132, 148, 189, 137, 213, 255, 80, 238)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IESimServiceInfo
  {
    ESimAuthenticationPreference AuthenticationPreference { get; }

    bool IsESimUiEnabled { get; }
  }
}
