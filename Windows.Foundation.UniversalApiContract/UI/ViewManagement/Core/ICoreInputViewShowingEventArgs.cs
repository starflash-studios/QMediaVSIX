// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreInputViewShowingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (CoreInputViewShowingEventArgs))]
  [Guid(3394381339, 64414, 23983, 169, 140, 38, 43, 139, 118, 175, 80)]
  internal interface ICoreInputViewShowingEventArgs
  {
    bool TryCancel();
  }
}
