// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.IPickerClosingDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2063071006, 6759, 18993, 174, 128, 233, 7, 112, 138, 97, 155)]
  [ExclusiveTo(typeof (PickerClosingDeferral))]
  internal interface IPickerClosingDeferral
  {
    void Complete();
  }
}
