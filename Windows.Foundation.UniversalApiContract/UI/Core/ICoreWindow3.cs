// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindow3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreWindow))]
  [Guid(851578328, 64239, 17269, 162, 171, 50, 100, 14, 72, 21, 199)]
  internal interface ICoreWindow3
  {
    event TypedEventHandler<CoreWindow, ClosestInteractiveBoundsRequestedEventArgs> ClosestInteractiveBoundsRequested;

    string GetCurrentKeyEventDeviceId();
  }
}
