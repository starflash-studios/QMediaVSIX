// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkDrawingAttributes4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkDrawingAttributes))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4016430117, 40729, 17773, 145, 163, 188, 58, 61, 145, 197, 251)]
  internal interface IInkDrawingAttributes4
  {
    bool IgnoreTilt { get; set; }
  }
}
