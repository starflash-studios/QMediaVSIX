// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInjectedInputKeyboardInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [ExclusiveTo(typeof (InjectedInputKeyboardInfo))]
  [Guid(1262932288, 11114, 24570, 126, 174, 189, 7, 123, 5, 42, 205)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInjectedInputKeyboardInfo
  {
    InjectedInputKeyOptions KeyOptions { get; set; }

    ushort ScanCode { get; set; }

    ushort VirtualKey { get; set; }
  }
}
