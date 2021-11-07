// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreFrameworkInputView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (CoreFrameworkInputView))]
  [Guid(3615265966, 18104, 23882, 148, 137, 141, 222, 195, 214, 57, 166)]
  internal interface ICoreFrameworkInputView
  {
    event TypedEventHandler<CoreFrameworkInputView, CoreFrameworkInputViewAnimationStartingEventArgs> PrimaryViewAnimationStarting;

    event TypedEventHandler<CoreFrameworkInputView, CoreFrameworkInputViewOcclusionsChangedEventArgs> OcclusionsChanged;
  }
}
