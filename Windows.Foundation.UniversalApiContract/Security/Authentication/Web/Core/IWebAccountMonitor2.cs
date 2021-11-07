// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebAccountMonitor2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (WebAccountMonitor))]
  [Guid(2813182456, 9400, 20225, 154, 229, 36, 84, 94, 113, 35, 58)]
  internal interface IWebAccountMonitor2
  {
    event TypedEventHandler<WebAccountMonitor, WebAccountEventArgs> AccountPictureUpdated;
  }
}
