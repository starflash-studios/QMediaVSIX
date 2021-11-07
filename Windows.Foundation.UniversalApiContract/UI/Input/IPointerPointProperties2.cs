// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerPointProperties2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PointerPointProperties))]
  [Guid(583222074, 51259, 16832, 162, 150, 94, 35, 45, 100, 214, 175)]
  internal interface IPointerPointProperties2
  {
    IReference<float> ZDistance { get; }
  }
}
