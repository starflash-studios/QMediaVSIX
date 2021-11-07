// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindow2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(2083199877, 26903, 17249, 156, 2, 13, 158, 58, 66, 11, 149)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreWindow))]
  [WebHostHidden]
  internal interface ICoreWindow2
  {
    Point PointerPosition { set; }
  }
}
