// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPasswordBoxStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2731397913, 44394, 17234, 181, 144, 246, 150, 255, 203, 142, 63)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PasswordBox))]
  [WebHostHidden]
  internal interface IPasswordBoxStatics3
  {
    DependencyProperty PasswordRevealModeProperty { get; }

    DependencyProperty TextReadingOrderProperty { get; }

    DependencyProperty InputScopeProperty { get; }
  }
}
