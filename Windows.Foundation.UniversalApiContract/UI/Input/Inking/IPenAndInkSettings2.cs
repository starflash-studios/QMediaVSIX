// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IPenAndInkSettings2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (PenAndInkSettings))]
  [Guid(845339219, 8004, 21986, 153, 41, 235, 247, 126, 84, 129, 184)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  internal interface IPenAndInkSettings2
  {
    void SetPenHandedness(PenHandedness value);
  }
}
