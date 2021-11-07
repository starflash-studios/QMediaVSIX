// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.Preview.ISystemNavigationManagerPreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core.Preview
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3965650056, 25637, 18295, 165, 54, 203, 86, 52, 66, 127, 13)]
  [ExclusiveTo(typeof (SystemNavigationManagerPreview))]
  internal interface ISystemNavigationManagerPreview
  {
    event EventHandler<SystemNavigationCloseRequestedPreviewEventArgs> CloseRequested;
  }
}
