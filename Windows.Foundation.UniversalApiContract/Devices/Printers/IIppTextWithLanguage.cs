// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IIppTextWithLanguage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [ExclusiveTo(typeof (IppTextWithLanguage))]
  [Guid(845432742, 20809, 22838, 144, 232, 12, 115, 96, 54, 191, 119)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IIppTextWithLanguage
  {
    string Language { get; }

    string Value { get; }
  }
}
