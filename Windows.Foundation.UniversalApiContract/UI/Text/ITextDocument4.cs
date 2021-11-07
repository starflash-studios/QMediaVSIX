// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextDocument4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [WebHostHidden]
  [Guid(1637622002, 52027, 17697, 152, 31, 40, 101, 177, 185, 63, 4)]
  [ExclusiveTo(typeof (RichEditTextDocument))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface ITextDocument4
  {
    void SetMath(string value);

    void GetMath(out string value);

    void SetMathMode(RichEditMathMode mode);
  }
}
