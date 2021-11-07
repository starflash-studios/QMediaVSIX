// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextPointer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (TextPointer))]
  [WebHostHidden]
  [Guid(2892528289, 27201, 17407, 133, 30, 69, 52, 138, 162, 207, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITextPointer
  {
    DependencyObject Parent { get; }

    FrameworkElement VisualParent { get; }

    LogicalDirection LogicalDirection { get; }

    int Offset { get; }

    Rect GetCharacterRect(LogicalDirection direction);

    TextPointer GetPositionAtOffset(int offset, LogicalDirection direction);
  }
}
