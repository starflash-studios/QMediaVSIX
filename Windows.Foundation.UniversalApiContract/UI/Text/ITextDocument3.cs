// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextDocument3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [WebHostHidden]
  [ExclusiveTo(typeof (RichEditTextDocument))]
  [Guid(1974141857, 42744, 17437, 170, 24, 10, 133, 29, 110, 94, 60)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ITextDocument3
  {
    void ClearUndoRedoHistory();
  }
}
