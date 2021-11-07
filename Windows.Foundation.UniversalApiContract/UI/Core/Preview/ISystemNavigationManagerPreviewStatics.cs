// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.Preview.ISystemNavigationManagerPreviewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core.Preview
{
  [ExclusiveTo(typeof (SystemNavigationManagerPreview))]
  [Guid(244781920, 57204, 19406, 132, 203, 189, 17, 129, 172, 10, 113)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISystemNavigationManagerPreviewStatics
  {
    SystemNavigationManagerPreview GetForCurrentView();
  }
}
