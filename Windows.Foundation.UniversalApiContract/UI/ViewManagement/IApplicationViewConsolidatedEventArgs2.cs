// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewConsolidatedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(471441100, 28097, 16628, 175, 238, 7, 217, 234, 41, 100, 48)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ApplicationViewConsolidatedEventArgs))]
  internal interface IApplicationViewConsolidatedEventArgs2
  {
    bool IsAppInitiated { get; }
  }
}
