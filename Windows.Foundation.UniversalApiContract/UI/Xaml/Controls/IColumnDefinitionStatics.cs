// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IColumnDefinitionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ColumnDefinition))]
  [WebHostHidden]
  [Guid(112252712, 53316, 16582, 148, 46, 174, 96, 234, 199, 72, 81)]
  internal interface IColumnDefinitionStatics
  {
    DependencyProperty WidthProperty { get; }

    DependencyProperty MaxWidthProperty { get; }

    DependencyProperty MinWidthProperty { get; }
  }
}
