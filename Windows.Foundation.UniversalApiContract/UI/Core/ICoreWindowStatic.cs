// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindowStatic
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(1294176261, 15402, 16817, 144, 34, 83, 107, 185, 207, 147, 177)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreWindow))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreWindowStatic
  {
    CoreWindow GetForCurrentThread();
  }
}
