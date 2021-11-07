// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ISystemNavigationManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2354119681, 26558, 18862, 149, 9, 103, 28, 30, 84, 163, 137)]
  [ExclusiveTo(typeof (SystemNavigationManager))]
  internal interface ISystemNavigationManager2
  {
    AppViewBackButtonVisibility AppViewBackButtonVisibility { get; set; }
  }
}
