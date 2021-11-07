// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IppTextWithLanguage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IIppTextWithLanguageFactory), 851968, "Windows.Foundation.UniversalApiContract")]
  public sealed class IppTextWithLanguage : IIppTextWithLanguage
  {
    [MethodImpl]
    public extern IppTextWithLanguage(string language, string text);

    public extern string Language { [MethodImpl] get; }

    public extern string Value { [MethodImpl] get; }
  }
}
