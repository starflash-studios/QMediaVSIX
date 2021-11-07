// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ICustomSystemEventTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(4082722712, 53099, 20212, 160, 202, 41, 207, 74, 39, 140, 135)]
  [ExclusiveTo(typeof (CustomSystemEventTrigger))]
  internal interface ICustomSystemEventTrigger
  {
    string TriggerId { get; }

    CustomSystemEventTriggerRecurrence Recurrence { get; }
  }
}
