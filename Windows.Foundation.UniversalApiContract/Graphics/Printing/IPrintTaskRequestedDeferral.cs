// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskRequestedDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(3488592880, 52798, 17095, 148, 150, 100, 128, 12, 98, 44, 68)]
  [ExclusiveTo(typeof (PrintTaskRequestedDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPrintTaskRequestedDeferral
  {
    void Complete();
  }
}
