// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxBeforeTextChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2773753267, 30596, 16984, 170, 131, 228, 190, 221, 114, 116, 103)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TextBoxBeforeTextChangingEventArgs))]
  internal interface ITextBoxBeforeTextChangingEventArgs
  {
    string NewText { get; }

    bool Cancel { get; set; }
  }
}
