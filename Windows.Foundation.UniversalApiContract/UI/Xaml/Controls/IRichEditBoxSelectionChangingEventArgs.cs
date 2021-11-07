// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBoxSelectionChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2430600028, 59576, 23603, 152, 150, 78, 152, 157, 101, 130, 156)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (RichEditBoxSelectionChangingEventArgs))]
  internal interface IRichEditBoxSelectionChangingEventArgs
  {
    int SelectionStart { get; }

    int SelectionLength { get; }

    bool Cancel { get; set; }
  }
}
