// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVisual3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(817780749, 62646, 19127, 128, 221, 55, 56, 203, 172, 159, 44)]
  [ExclusiveTo(typeof (Visual))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  internal interface IVisual3
  {
    bool IsHitTestVisible { get; set; }
  }
}
