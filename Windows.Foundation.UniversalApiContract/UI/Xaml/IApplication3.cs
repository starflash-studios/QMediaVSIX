// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IApplication3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (Application))]
  [WebHostHidden]
  [Guid(3077942652, 6328, 17866, 161, 176, 220, 72, 62, 75, 16, 40)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IApplication3
  {
    ApplicationHighContrastAdjustment HighContrastAdjustment { get; set; }
  }
}
