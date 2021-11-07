// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IESimProfilePolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (ESimProfilePolicy))]
  [Guid(3873247005, 40028, 18117, 162, 137, 169, 72, 153, 155, 240, 98)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IESimProfilePolicy
  {
    bool CanDelete { get; }

    bool CanDisable { get; }

    bool IsManagedByEnterprise { get; }
  }
}
