// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.Preview.ICoreAppWindowPreviewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.WindowManagement;

namespace Windows.UI.Core.Preview
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreAppWindowPreview))]
  [Guid(866918846, 16955, 23990, 138, 142, 77, 200, 115, 83, 183, 91)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ICoreAppWindowPreviewStatics
  {
    int GetIdFromWindow(AppWindow window);
  }
}
