// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationView7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(2687931975, 24495, 23206, 156, 56, 190, 251, 177, 42, 7, 30)]
  [ExclusiveTo(typeof (ApplicationView))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  internal interface IApplicationView7
  {
    string PersistedStateId { get; set; }
  }
}
