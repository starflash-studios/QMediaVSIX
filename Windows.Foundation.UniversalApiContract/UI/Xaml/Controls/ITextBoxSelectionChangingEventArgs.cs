// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxSelectionChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2222597341, 39614, 21215, 168, 10, 12, 206, 75, 73, 102, 50)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TextBoxSelectionChangingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ITextBoxSelectionChangingEventArgs
  {
    int SelectionStart { get; }

    int SelectionLength { get; }

    bool Cancel { get; set; }
  }
}
