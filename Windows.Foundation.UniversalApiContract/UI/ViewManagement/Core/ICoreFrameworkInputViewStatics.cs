// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreFrameworkInputViewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [ExclusiveTo(typeof (CoreFrameworkInputView))]
  [Guid(1860950454, 60098, 24459, 151, 95, 119, 46, 227, 228, 46, 235)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface ICoreFrameworkInputViewStatics
  {
    CoreFrameworkInputView GetForUIContext(UIContext context);

    CoreFrameworkInputView GetForCurrentView();
  }
}
