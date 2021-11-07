// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebAccountMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  [ExclusiveTo(typeof (WebAccountMonitor))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1950742013, 43677, 17945, 141, 93, 193, 56, 164, 237, 227, 229)]
  internal interface IWebAccountMonitor
  {
    event TypedEventHandler<WebAccountMonitor, WebAccountEventArgs> Updated;

    event TypedEventHandler<WebAccountMonitor, WebAccountEventArgs> Removed;

    event TypedEventHandler<WebAccountMonitor, object> DefaultSignInAccountChanged;
  }
}
