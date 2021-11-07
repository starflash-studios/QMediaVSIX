// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUIActivationStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ExclusiveTo(typeof (WebUIApplication))]
  [Guid(1580799017, 6207, 18317, 138, 37, 103, 248, 13, 3, 147, 91)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IWebUIActivationStatics4
  {
    event EventHandler<NewWebUIViewCreatedEventArgs> NewWebUIViewCreated;

    event BackgroundActivatedEventHandler BackgroundActivated;
  }
}
