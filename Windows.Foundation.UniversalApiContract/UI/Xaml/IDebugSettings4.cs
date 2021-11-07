// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDebugSettings4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DebugSettings))]
  [Guid(3372228165, 59428, 23135, 134, 108, 226, 12, 236, 136, 168, 252)]
  internal interface IDebugSettings4
  {
    bool FailFastOnErrors { get; set; }
  }
}
