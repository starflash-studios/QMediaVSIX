// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IInsetClip
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InsetClip))]
  [Guid(510912071, 33991, 18298, 180, 116, 88, 128, 224, 68, 46, 21)]
  internal interface IInsetClip
  {
    float BottomInset { get; set; }

    float LeftInset { get; set; }

    float RightInset { get; set; }

    float TopInset { get; set; }
  }
}
