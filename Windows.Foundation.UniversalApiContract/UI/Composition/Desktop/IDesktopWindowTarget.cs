// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Desktop.IDesktopWindowTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Desktop
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (DesktopWindowTarget))]
  [WebHostHidden]
  [Guid(1663686346, 13158, 18702, 157, 179, 37, 49, 41, 41, 172, 81)]
  internal interface IDesktopWindowTarget
  {
    bool IsTopmost { get; }
  }
}
