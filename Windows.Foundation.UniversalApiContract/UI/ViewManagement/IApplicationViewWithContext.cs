// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewWithContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ApplicationView))]
  [WebHostHidden]
  [Guid(3176518930, 40385, 17660, 133, 1, 102, 102, 37, 223, 96, 220)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IApplicationViewWithContext
  {
    UIContext UIContext { get; }
  }
}
