// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUIActivationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [Guid(890996413, 17331, 18475, 133, 219, 53, 216, 123, 81, 122, 217)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebUIApplication))]
  internal interface IWebUIActivationStatics
  {
    event ActivatedEventHandler Activated;

    event SuspendingEventHandler Suspending;

    event ResumingEventHandler Resuming;

    event NavigatedEventHandler Navigated;
  }
}
