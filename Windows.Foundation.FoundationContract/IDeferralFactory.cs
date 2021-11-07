// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IDeferralFactory
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [ExclusiveTo(typeof (Deferral))]
  [Guid(1705110725, 16309, 18482, 140, 169, 240, 97, 178, 129, 209, 58)]
  internal interface IDeferralFactory
  {
    Deferral Create(DeferralCompletedHandler handler);
  }
}
