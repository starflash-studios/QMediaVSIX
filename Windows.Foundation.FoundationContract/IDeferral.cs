// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IDeferral
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ExclusiveTo(typeof (Deferral))]
  [Guid(3592853298, 15231, 18087, 180, 11, 79, 220, 162, 162, 198, 147)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  internal interface IDeferral : IClosable
  {
    void Complete();
  }
}
