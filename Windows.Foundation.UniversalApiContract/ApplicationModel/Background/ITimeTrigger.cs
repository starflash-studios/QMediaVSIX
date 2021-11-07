// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ITimeTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (TimeTrigger))]
  [Guid(1701729622, 2858, 17271, 186, 112, 59, 69, 169, 53, 84, 127)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimeTrigger : IBackgroundTrigger
  {
    uint FreshnessTime { get; }

    bool OneShot { get; }
  }
}
