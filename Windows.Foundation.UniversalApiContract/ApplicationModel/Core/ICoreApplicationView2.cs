// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplicationView2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.ApplicationModel.Core
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreApplicationView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1760262879, 37247, 18667, 154, 235, 125, 229, 62, 8, 106, 177)]
  internal interface ICoreApplicationView2
  {
    CoreDispatcher Dispatcher { get; }
  }
}
